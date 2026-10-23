using Practiceforunstd2;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using Newtonsoft.Json;
using System.Globalization;

namespace offerletter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            User ouser = new User();
              ouser.Name = txtname.Text;
              ouser.Username = txtusernamename.Text;
              ouser.Password = txtpassword.Password;
              ouser.Adress = txtadress.Text;
              ouser.Position = txtposition.Text;
              ouser.Degree = txtdegree.Text;
        

            string value = JsonConvert.SerializeObject(ouser);
            string rootpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            string projectfolder = Path.Combine(rootpath, "Students");
            Directory.CreateDirectory(projectfolder);
            string filepath = Path.Combine(projectfolder, $"{txtusernamename.Text}.txt");
            if(File.Exists (filepath))
            {
                MessageBox.Show("File Already Exists");
            }
            else
            {
                File.WriteAllText(filepath, value);
                MessageBox.Show("Success");
            }
           











            //string offerletter = "Offer Letter\r\n\r\nDate: {date} \r\nName: {name}  \r\nAddress: {adress}  \r\nPosition: {position}  \r\nDegree: {degree}  \r\n\r\nDear {name},  \r\nWe are pleased to offer you the role of {position} Your {degree} makes you a strong fit for our team.  \r\n\r\nSincerely,  \r\n Team Accenture \r\n\r\n\r\n\r\n";
            //offerletter = offerletter.Replace("{date}", DateTime.Now.ToString());
            //offerletter = offerletter.Replace("{adress}", txtadress.Text);
            //offerletter = offerletter.Replace("{name}", txtname.Text);
            //offerletter = offerletter.Replace("{position}", txtposition.Text);
            //offerletter = offerletter.Replace("{degree}", txtdegree.Text);
            //offerletter = offerletter.Replace("{Comapny}", "Team Accenture");
            //txtoffer.Text = offerletter;

            string offerletter = $@"Offer Letter
            
            Date: {DateTime.Now:dd-MM-yyyy}
            Name: {txtname.Text}
            Address: {txtadress.Text}
            Position: {txtposition.Text}
            Degree: {txtdegree.Text}

            Dear {txtname.Text},
            We are pleased to offer you the role of {txtposition.Text}. Your {txtdegree.Text} makes you a strong fit for our team.
            Sincerely,
            Team Accenture";

            txtoffer.Text = offerletter;
        }
    }
}