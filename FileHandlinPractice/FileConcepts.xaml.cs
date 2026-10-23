using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace clses
{
    /// <summary>
    /// Interaction logic for FileConcepts.xaml
    /// </summary>
    public partial class FileConcepts : Window
    {
        public FileConcepts()
        {
            InitializeComponent();
        }

        private void Createfile_Click(object sender, RoutedEventArgs e)
        {
           
            
                File.Create("C:\\images\\Vasanth.txt");
                File.Create("C:\\images\\Kani.txt");
                File.Create("C:\\images\\Thiru.txt");
                MessageBox.Show("File Created");

            

        }
        private void writefile_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("C:\\images\\Vasanth.txt", "Hi My Name is Vasanthasenan");

            //file already exits and then text will replace
        }

        private void readfile_Click(object sender, RoutedEventArgs e)
        {
            string value = File.ReadAllText("C:\\images\\Vasanth.txt");
            MessageBox.Show(value);
        }

        private void deletefile_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("C:\\images\\Vasanth.txt");
        }

        private void btnCreatefolder_Click(object sender, RoutedEventArgs e)
        {
           if(Directory.Exists("C:\\images\\Student"))
            {
                MessageBox.Show("File Already Exits");
            }
           else
            {
                Directory.CreateDirectory("C:\\images\\Student");
                MessageBox.Show("Folder Created");
            }
        }
 
        private void btndeletefolder_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists("C:\\images\\Student"))
            {
                Directory.Delete("C:\\images\\Student");
                MessageBox.Show("Folder Deleted");
            }
        }

        private void btngetfiles_Click(object sender, RoutedEventArgs e)
        {
            string[] filepath = Directory.GetFiles("C:\\Users\\ELCOT\\OneDrive\\Pictures\\Screenshots");
            foreach (string filenames in filepath)
            {
                MessageBox.Show(filenames);
            }
        }
    }
}
