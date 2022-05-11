using System;               // needed for AppContext
using System.IO;            // needed for File
using System.Windows;       // needed for RoutedEventArgs, Window
using Microsoft.Win32;      // needed for OpenFileDialog

namespace Ex_07_01
{
    // Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**********************************************************************/

        // This method is run after clicking "LoadPath" in Menu/File
        private void MenuFileLoadPath_Click(object sender, RoutedEventArgs e)
        {
            // Open a file with the MP3 folder path (copy text from a file to the TextBox)
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppContext.BaseDirectory; // or @"C:\Windows\"
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
                TextPath.Text = File.ReadAllText(openFileDialog.FileName);
        }

        /**********************************************************************/

        // This method is run after clicking "SavePath" in Menu/File
        private void MenuFileSavePath_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        /**********************************************************************/

        private void MenuFileExit_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        /**********************************************************************/

        private void MenuInfoAbout_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        /**********************************************************************/

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }
    }
}
