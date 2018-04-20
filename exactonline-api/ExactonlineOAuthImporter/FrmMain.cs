using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



namespace ExactonlineOAuthImporter
{
    public partial class FrmMain : Form
    {
        private DotNetOpenAuth.OAuth2.IAuthorizationState AuthorisationState;
        private string AuthToken;
        private string RefreshToken;
        private static readonly HttpClient client = new HttpClient();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "Exact.ini"));
           string dirtobeprocessed = ini.IniReadValue("appsettings", "XMLDirectoryToBeProcessed");

            lbxFiles.Items.Clear();
            OpenFileDialog theDialog = new OpenFileDialog();
            if (Directory.Exists(dirtobeprocessed)) //   @"C:\VeluweGranen\ExactFiles\ToBeProcessed"))
            {
                theDialog.InitialDirectory = dirtobeprocessed;// @"C:\VeluweGranen\ExactFiles\ToBeProcessed";
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            //  tbxClientID.Text = ConfigurationManager.AppSettings["ApplicationKey"].ToString();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.Text = "Exact online importer " + version;
            IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "Exact.ini"));
            tbxDescription.Text = ini.IniReadValue("appsettings", "ExactOmschrijving");
            tbxClientID.Text = ini.IniReadValue("appsettings", "ApplicationKey");
            tbxClientSecret.Text = ini.IniReadValue("appsettings", "ClientSecret");
            tbxRedirect.Text = ini.IniReadValue("appsettings", "ExactOnlineURL");
            txtProcessedDir.Text = ini.IniReadValue("appsettings", "XMLDirectoryProcessed");
            txtError.Text = ini.IniReadValue("appsettings", "XMLDirectoryError");
            tbxRedirect.Text = ini.IniReadValue("appsettings", "RedirectURL");

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "Exact.ini"));
            if(!Directory.Exists(ini.IniReadValue("appsettings", "XMLDirectoryError")))
            {
                MessageBox.Show("Specify a valid directory for the errorfiles first (XMLDirectoryError)");
                return;
            }
            if (!Directory.Exists(ini.IniReadValue("appsettings", "XMLDirectoryProcessed")))
            {
                MessageBox.Show("Specify a valid directory for the processed files first (XMLDirectoryProcessed)");
                return;
            }
            if (!Directory.Exists(ini.IniReadValue("appsettings", "XMLDirectoryToBeProcessed")))
            {
                MessageBox.Show("Specify a valid directory for the TO BE processed files first (XMLDirectoryToBeProcessed)");
                return;
            }

            if (lbxFiles.Items.Count > 0)
            {
                btnUpload.Enabled = false;

                label1.Visible = true;
                label1.Text = "Uploading, logging in..";
                try

                {
                    string Password = ini.IniReadValue("appsettings", "Password");

                    Clipboard.SetText(Password);

                    //        ExactOnlineClient client = new ExactOnlineClient(apiEndPoint, AccessTokenDelegate);
                    Uri re = new Uri(tbxRedirect.Text);
                    DotNetOpenAuth.OAuth2.AuthorizationServerDescription asd = new DotNetOpenAuth.OAuth2.AuthorizationServerDescription();
                    asd.AuthorizationEndpoint = new Uri("https://start.exactonline.nl/api/oauth2/auth");
                    asd.TokenEndpoint = new Uri("https://start.exactonline.nl/api/oauth2/token");
                    ExactOnline.Client.OAuth.OAuthClient oc = new ExactOnline.Client.OAuth.OAuthClient(asd, tbxClientID.Text, tbxClientSecret.Text, re);

                    oc.Authorize(ref AuthorisationState, AuthToken);

                    AuthToken = AuthorisationState.AccessToken;   //  oc.Toekenresult;
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
                    int Waitcounter = 0;
                    string reportstring = "";
                    foreach (String file in lbxFiles.Items)
                    {
                        label1.Text = "Uploading: " + file;
                        Waitcounter++;
                        if (Waitcounter > 20)
                        {
                            System.Threading.Thread.Sleep(25000); //wacht 25 seconden;
                            RefreshToken = AuthorisationState.RefreshToken;
                            Waitcounter = 0;
                        }
                        try
                        {
                            Application.DoEvents();
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.Load(file);
                            string xmlstring = GetXMLAsString(xdoc);
                            postXMLData("https://start.exactonline.nl/docs/XMLUpload.aspx?forece_login=0&Topic=GLTransactions&_Division_=" + ini.IniReadValue("appsettings", "Administration"), xmlstring, oc, file);
                            Application.DoEvents();

                            string filename = Path.GetFileName(file);
                            File.Move(file, Path.Combine(txtProcessedDir.Text, filename)); // Try to move to processed
                            resultimport.Add("Success! " + filename);
                            reportstring += Environment.NewLine + "Succes! " + filename;
                        }
                        catch (Exception)
                        {
                                string filename = Path.GetFileName(file);
                            //        File.Move(file, Path.Combine(txtError.Text, filename)); // Try to move to error

                            //       MessageBox.Show("upload went wrong with file: " + file + " Exception: " + ex.Message + "  " + ex.InnerException);
                            //         SendGridWrapper sg = new SendGridWrapper();
                            //         sg.SendMail(ini.IniReadValue("appsettings", "mailto"), "Exact importer gebruiker", "Exception tijdens uploaden", "De upload kwam een fout tegen in de volgende file: " + file + Environment.NewLine + "Foutmelding: " + ex.Message, ini.IniReadValue("appsettings", "mailfrom"));

                        }
                    }
                    lbxFiles.Items.Clear();
                    lbxFiles.Items.AddRange(resultimport.ToArray());
                    label1.ForeColor = Color.Green;
                    label1.Text = "Finished succesfully!";
                    SendGridWrapper sg = new SendGridWrapper();
                    sg.SendMail(ini.IniReadValue("appsettings", "mailto"), "Exact importer gebruiker", "De upload was succesvol op " + DateTime.Now.ToString("D"), "De upload was succesvol op: "
                        + DateTime.Now.ToString("D")
                        + Environment.NewLine + "File lijst:"
                        + Environment.NewLine + reportstring, ini.IniReadValue("appsettings", "mailfrom"));

                }
                catch (Exception ex)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Errors while uploading (email sent)";
                    //   MessageBox.Show("Something went wrong: " + ex.Message);
                    SendGridWrapper sg = new SendGridWrapper();
                    sg.SendMail(ini.IniReadValue("appsettings", "mailto"), "Exact importer gebruiker", "Exception tijdens uploaden", "De upload kwam een fout tegen" + Environment.NewLine + "Foutmelding: " + ex.Message, ini.IniReadValue("appsettings", "mailfrom"));
                }
                finally
                {
                    btnUpload.Enabled = true;
                    label1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("First select at least one file");
            }
        }

        public string postXMLData(string destinationUrl, string requestXml, ExactOnline.Client.OAuth.OAuthClient _oc, string _file)
        {
            IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "Exact.ini"));
            Application.DoEvents();
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
                request.Headers.Add("force_login", "0");
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
                //als het fout gaat, verplaats de file dan naar de error directory
                MessageBox.Show("Something went wrong while posting the xml document: " + ex.Message + Environment.NewLine + "The upload is not completed successfully");
                SendGridWrapper sg = new SendGridWrapper();
                sg.SendMail(ini.IniReadValue("appsettings", "mailto"), "Exact importer gebruiker", "Exception tijdens uploaden", "De upload kwam een fout tegen in de volgende file: " + _file + Environment.NewLine + "Foutmelding: " + ex.Message, ini.IniReadValue("appsettings", "mailfrom"));

                File.Move(Path.GetFileName(_file), Path.Combine(ini.IniReadValue("appsettings", "XMLDirectoryError"), Path.GetFileName(Path.GetFileName(_file))));
                //    send   SendMail(mailto, "Veluwegranen", "Process file fout: " & Path.GetFileName(filename), "Exact Online Import error at processing XML Import file" & ex.Message, mailfrom)


            }
            return null;
        }

        public string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString(); 
            return str;
        }

        private void btnEditIniFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Application.StartupPath, "Exact.ini")))
            {
                  
                        Process.Start(Path.Combine(Application.StartupPath, "Exact.ini"));

                   
                
            }
        }
    }
}
