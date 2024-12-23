using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PingniteUI
{
    /// <summary>
    /// Interaction logic for Username.xaml
    /// </summary>
    public partial class Username : Window
    {
        public Username()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }


        private void Button_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists("FTracker"))
            {
                // 3. Create the folder
                Directory.CreateDirectory("FTracker");
                Console.WriteLine($"Folder created successfully at: {"FTracker"}");
            }
            else
            {
                Console.WriteLine($"Folder already exists at: {"FTracker"}");
            }


            if (string.IsNullOrEmpty(Usernamee.Text))
            {
                MessageBox.Show("Username is empty.");
            }
            else {

                StreamWriter File = new StreamWriter("FTracker/FTrackerTUserData.json");
                File.WriteLine("Username : ");
                File.WriteLine(Usernamee.Text);
                File.Close();
                Loading.Visibility = 0;
               
                for (int i = 0; i < 100; i++)
                {
                    
                    Loading.Opacity += 0.01;
                    
                }
                Loadingsss.Content = "Saving Username...";
                System.Threading.Thread.Sleep(2000);
         
                
                Loadingsss.Content = "Opening Launcher...";
                Task.Delay(500);

                Task.Delay(1999999);

                MainWindow Launcher = new MainWindow();


                Launcher.Show();

                this.Close();
            }
            


        }


    }
}
