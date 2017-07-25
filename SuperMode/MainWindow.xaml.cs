//autor: Carlos Oviedo 
//descripcion: programa para hacer aparecer el super control panel (superMode)
//fecha: Septiembre, 9 2016

using System;
using System.Windows;
using System.IO;

namespace SuperMode
{
    public partial class MainWindow : Window
    {

        const string superName = "\\SuperMode.{ED7BA470-8E54-465E-825C-99712043E01C}";
        string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public MainWindow()
        {
            InitializeComponent();
        }
        //make the superMode folder in the desktop
        private void MakeSuper(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("The user desktop directory is " + deskDir);

            if (!Directory.Exists(deskDir + superName))
            {
                Directory.CreateDirectory(deskDir + superName);
            }
        }
        
        //delete the superMode folder from the desktop
        private void DeleteSuper(object sender, RoutedEventArgs e)
        {
            if(Directory.Exists(deskDir + superName))
            {
                Directory.Delete(deskDir + superName, true);
            }
        }
    }
}
