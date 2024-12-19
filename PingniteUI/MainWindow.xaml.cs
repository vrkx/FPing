using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PingniteUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            // Start app
            InitializeComponent();
            // Ping servers and get information about them.

            // EAST
            Ping pingea = new Ping();
            PingReply replyea = pingea.Send("ping-nae.ds.on.epicgames.com", 1000);
            ServerN.Content = "NA-EAST";
            NaServer.Content = "ping-nae.ds.on.epicgames.com";

            NaMS.Content = replyea.RoundtripTime + "MS";
            NaSTATUS.Content = replyea.Status;


            Ping pingwe = new Ping();
            PingReply replywe = pingwe.Send("ping-naw.ds.on.epicgames.com", 1000);
            ServerN1.Content = "NA-WEST";
            NaServer1.Content = "ping-naw.ds.on.epicgames.com";

            NaMS1.Content = replywe.RoundtripTime + "MS";
            NaSTATUS1.Content = replywe.Status;

            Ping pingnac = new Ping();
            PingReply replynac = pingnac.Send("ping-nac.ds.on.epicgames.com", 1000);
            ServerN2.Content = "NA-CENTRAL";
            NaServer2.Content = "ping-nac.ds.on.epicgames.com";

            NaMS2.Content = replynac.RoundtripTime + "MS";
            NaSTATUS2.Content = replynac.Status;

            Ping pingbr = new Ping();
            PingReply replybr = pingbr.Send("ping-br.ds.on.epicgames.com", 1000);
            ServerN3.Content = "BRAZIL";
            NaServer3.Content = "ping-br.ds.on.epicgames.com";

            NaMS3.Content = replybr.RoundtripTime + "MS";
            NaSTATUS3.Content = replybr.Status;


            Ping pingeu = new Ping();
            PingReply replyeu = pingeu.Send("ping-eu.ds.on.epicgames.com", 1000);
            ServerN4.Content = "EUROPE";
            NaServer4.Content = "ping-eu.ds.on.epicgames.com";

            NaMS4.Content = replyeu.RoundtripTime + "MS";
            NaSTATUS4.Content = replyeu.Status;


            Ping pingme = new Ping();
            PingReply replyme = pingme.Send("ping-me.ds.on.epicgames.com", 1000);
            ServerN5.Content = "MIDDLE-EAST";
            NaServer5.Content = "ping-me.ds.on.epicgames.com";

            NaMS5.Content = replyme.RoundtripTime + "MS";
            NaSTATUS5.Content = replyeu.Status;


            // Testing Servers and Changing Colors to the Embeds if servers are up or down
            // Not working fixing soon!

            if (NaSTATUS.Content.ToString() == "Success")
            {


                Console.WriteLine("Servers Up!");
            }
            else if (NaSTATUS.Content.ToString() == "Error")
            {

                Console.WriteLine("Servers Down :(");

            }

            // Uodate

        }




        // App drag when long click
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        // Github btn

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Process.Start("explorer", "http://github.com/vrkx/PingniteUI"); 
        }

        // Close app

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Refresh servers info

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            Task.Delay(500).Wait();
            Ping pingea = new Ping();
            PingReply replyea = pingea.Send("ping-nae.ds.on.epicgames.com", 1000);
            ServerN.Content = "NA-EAST";
            NaServer.Content = "ping-nae.ds.on.epicgames.com";
           
            NaMS.Content =  replyea.RoundtripTime + "MS";
            NaSTATUS.Content = replyea.Status;
            

            Ping pingwe = new Ping();
            PingReply replywe = pingwe.Send("ping-naw.ds.on.epicgames.com", 1000);
            ServerN1.Content = "NA-WEST";
            NaServer1.Content = "ping-naw.ds.on.epicgames.com";
           
            NaMS1.Content =   replywe.RoundtripTime + "MS";
            NaSTATUS1.Content = replywe.Status;

            Ping pingnac = new Ping();
            PingReply replynac = pingnac.Send("ping-nac.ds.on.epicgames.com", 1000);
            ServerN2.Content = "NA-CENTRAL";
            NaServer2.Content = "ping-nac.ds.on.epicgames.com";
          
            NaMS2.Content =   replynac.RoundtripTime + "MS";
            NaSTATUS2.Content = replynac.Status;

            Ping pingbr = new Ping();
            PingReply replybr = pingbr.Send("ping-br.ds.on.epicgames.com", 1000);
            ServerN3.Content = "BRAZIL";
            NaServer3.Content = "ping-br.ds.on.epicgames.com";
         
            NaMS3.Content =   replybr.RoundtripTime + "MS";
            NaSTATUS3.Content = replybr.Status;


            Ping pingeu = new Ping();
            PingReply replyeu = pingeu.Send("ping-eu.ds.on.epicgames.com", 1000);
            ServerN4.Content = "EUROPE";
            NaServer4.Content = "ping-eu.ds.on.epicgames.com";
        
            NaMS4.Content =   replyeu.RoundtripTime + "MS";
            NaSTATUS4.Content = replyeu.Status;


            Ping pingme = new Ping();
            PingReply replyme = pingme.Send("ping-me.ds.on.epicgames.com", 1000);
            ServerN5.Content = "MIDDLE-EAST";
            NaServer5.Content = "ping-me.ds.on.epicgames.com";
    
            NaMS5.Content =   replyme.RoundtripTime +"MS";
            NaSTATUS5.Content = replyeu.Status;

            



        }

        // Discord Invite ( Moving Soon )

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Process.Start("explorer", "https://discord.gg/MWhmZRDU");

        }



    }
}