using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace Practiceforunstd2
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        string rootpath;
        string projectfolder;
        string filepath;
        
        public Reg()
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            rootpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            projectfolder = Path.Combine(rootpath, "Students");
            Directory.CreateDirectory(projectfolder);
          
            InitializeComponent();
           
        }

    
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            filepath = Path.Combine(projectfolder, $"{txtusername.Text}.txt");
            if (File.Exists(filepath))
            {
                string value = File.ReadAllText(filepath);
                User userdata = JsonConvert.DeserializeObject<User>(value);
                if (userdata.Username == txtusername.Text && userdata.Password == txtpassword.Password)
                {
                    MessageBox.Show("Valid User");
                }
                else
                {
                    MessageBox.Show("InvalidUser");
                }
            }
            else
            {
                MessageBox.Show("Invalid User");
            }


      
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            // string offerletter = $@"#Offer Letter

            //Date: {DateTime.Now.ToString()}

            //To,
            //Name: {txtname.Text}
            //Address: {txtadress.Text}

            //Subject: Offer of Software Devoloper

            //Dear {txtname.Text}

            //We are pleased to offer you the position of {txtposition} at our company. Based on your qualifications and educational background in [Degree], we believe you will be a valuable addition to our team.

            //Your employment will begin on {DateTime.Now}. Further details regarding salary, work responsibilities, and company policies will be shared during the joining process.

            //Please confirm your acceptance of this offer by signing and returning a copy of this letter.

            //We look forward to working with you and wish you a successful career with us.

            //Sincerely,

            //HR Manager
            //Team Accenture";
            //txtoffer.Text = offerletter;





        }

    }
}
