using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Xml;
using System.Configuration;


namespace OAuthUploader
{
    public partial class FrmOAuthUploaderMain : Form
    {
        private DotNetOpenAuth.OAuth2.IAuthorizationState AuthorisationState;
        private string AuthToken;
        private string RefreshToken;
        private static readonly HttpClient client = new HttpClient();
        public FrmOAuthUploaderMain()
        {
            InitializeComponent();
        }

        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            lbxFiles.Items.Clear();
             OpenFileDialog theDialog = new OpenFileDialog();
            if (Directory.Exists(ConfigurationManager.AppSettings["XMLDirectoryToBeProcessed"].ToString())) // @"C:\VeluweGranen\ExactFiles\ToBeProcessed"))
            {
                theDialog.InitialDirectory = ConfigurationManager.AppSettings["XMLDirectoryToBeProcessed"].ToString();
            }


            theDialog.Title = "Select xml files";
            theDialog.Filter = "XML files|*.xml";
             theDialog.Multiselect = true;
            lbxFiles.Items.Clear();
            DialogResult dr = theDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in theDialog.FileNames)
                {
                    try
                    {
                        lbxFiles.Items.Add(file);

                    }

                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lbxFiles.Items.Count > 0)
            {
                btnUpload.Enabled = false;

                label1.Visible = true;
                label1.Text = "Uploading, logging in..";
                try

                {
                    string Password = ConfigurationManager.AppSettings["ExactPassword"].ToString();
                    Clipboard.SetText(Password);

                    //        ExactOnlineClient client = new ExactOnlineClient(apiEndPoint, AccessTokenDelegate);
                    Uri re = new Uri(tbxRedirect.Text);
                    DotNetOpenAuth.OAuth2.AuthorizationServerDescription asd = new DotNetOpenAuth.OAuth2.AuthorizationServerDescription();
                    asd.AuthorizationEndpoint = new Uri("https://start.exactonline.nl/api/oauth2/auth");
                    asd.TokenEndpoint = new Uri("https://start.exactonline.nl/api/oauth2/token");
                    ExactOnline.Client.OAuth.OAuthClient oc = new ExactOnline.Client.OAuth.OAuthClient(asd, tbxClientID.Text, tbxClientSecret.Text, re);

                    oc.Authorize(ref AuthorisationState, AuthToken);

                    AuthToken = AuthorisationState.AccessToken;   //  oc.Tokenresult;
                    RefreshToken = AuthorisationState.RefreshToken;
                    textBox1.Text = AuthToken;
                    Application.DoEvents();
                    label1.ForeColor = Color.Blue;
                    label1.Text = "Logged in..";


                    ///gerard's exact account:
                    ///
                    /// gerard@veluwegranen.nl
                    /// 6713Vc09-2
                     // Clipboard.SetText("6713Vc09-2");

                    if (AuthToken.Length == 0)
                    {
                        MessageBox.Show("The token is empty!");
                        return;
                    }
                    //   RefreshToken = Prompt.ShowDialog("Token", "We need the token");
                    List<string> resultimport = new List<string>();
                    foreach (String file in lbxFiles.Items)
                    {
                        label1.Text = "Uploading: " + file;
                        try
                        {
                            Application.DoEvents();
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.Load(file);
                            string xmlstring = GetXMLAsString(xdoc);
                            postXMLData("https://start.exactonline.nl/docs/XMLUpload.aspx?Topic=GLTransactions&_Division_=" + ConfigurationManager.AppSettings["Administration"].ToString(), xmlstring, oc, file);
                            Application.DoEvents();

                            string filename = Path.GetFileName(file);
                            File.Move(file, Path.Combine(txtProcessedDir.Text, filename)); // Try to move to processed
                            resultimport.Add("Success! " + filename);
                        }
                        catch (Exception ex)
                        {
                            string filename = Path.GetFileName(file);
                            File.Move(file, Path.Combine(txtProcessedDir.Text, filename)); // Try to move to error

                            MessageBox.Show("upload went wrong with file: " + file + " Exception: " + ex.Message + "  " + ex.InnerException);
                        }
                    }
                    lbxFiles.Items.Clear();
                    lbxFiles.Items.AddRange(resultimport.ToArray());
                    label1.ForeColor = Color.Green;
                    label1.Text = "Finished succesfully!";            
                }
                catch (Exception ex)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Errors while uploading";
                    MessageBox.Show("Something went wrong: " + ex.Message);
                    MessageBox.Show("The upload is NOT completed successfully");
                }
                finally
                {
                    btnUpload.Enabled = true;
                    label1.Visible = false;
                }
            }
        }

        private void frmOAuthUploaderMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
          //  tbxClientID.Text = ConfigurationManager.AppSettings["ApplicationKey"].ToString();


        }

        public string postXMLData(string destinationUrl, string requestXml, ExactOnline.Client.OAuth.OAuthClient _oc, string _file)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}", destinationUrl));
                byte[] bytes;
                bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                request.ContentType = "text/xml; encoding='utf-8'";
                request.Headers.Add("Client_ID", tbxClientID.Text);
                request.Headers.Add("authorization", "Bearer " + AuthToken);
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response;

                _oc.AuthorizeRequest(request, AuthorisationState);

                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    string responseStr = new StreamReader(responseStream).ReadToEnd();
                    textBox1.Text += "  " + (responseStr);
                    return responseStr;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while posting the xml document: " + ex.Message + Environment.NewLine + "The upload is not completed successfully" );

                File.Move(Path.GetFileName(_file), Path.Combine(ConfigurationManager.AppSettings["XMLDirectoryError"].ToString(), Path.GetFileName(Path.GetFileName(_file))));
             //    send   SendMail(mailto, "Veluwegranen", "Process file fout: " & Path.GetFileName(filename), "Exact Online Import error at processing XML Import file" & ex.Message, mailfrom)


            }
            return null;
        }
    
        public string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }

        private void tbxRedirect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
