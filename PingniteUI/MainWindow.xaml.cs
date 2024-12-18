using System.Diagnostics;
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
            InitializeComponent();
            Ping pingea = new Ping();
            PingReply replyea = pingea.Send("ping-nae.ds.on.epicgames.com", 1000);
            NaIP.Content = "Ping : " + replyea.RoundtripTime + "ms";
            NaMS.Content = "Address : " + replyea.Address;
            NaSTATUS.Content = replyea.Status;

            Ping pingwe = new Ping();
            PingReply replywe = pingwe.Send("ping-naw.ds.on.epicgames.com", 1000);
            NaIP1.Content = "Ping : " + replywe.RoundtripTime + "ms";
            NaMS1.Content = "Address : " + replywe.Address;
            NaSTATUS1.Content = replywe.Status;

            Ping pingnac = new Ping();
            PingReply replynac = pingnac.Send("ping-nac.ds.on.epicgames.com", 1000);
            NaIP2.Content = "Ping : " + replynac.RoundtripTime + "ms";
            NaMS2.Content = "Address : " + replynac.Address;
            NaSTATUS2.Content = replynac.Status;

            Ping pingbr = new Ping();
            PingReply replybr = pingbr.Send("ping-br.ds.on.epicgames.com", 1000);
            NaIP3.Content = "Ping : " + replybr.RoundtripTime + "ms";
            NaMS3.Content = "Address : " + replybr.Address;
            NaSTATUS3.Content = replybr.Status;


            Ping pingeu = new Ping();
            PingReply replyeu = pingeu.Send("ping-eu.ds.on.epicgames.com", 1000);
            NaIP4.Content = "Ping : " + replyeu.RoundtripTime + "ms";
            NaMS4.Content = "Address : " + replyeu.Address;
            NaSTATUS4.Content = replyeu.Status;


            Ping pingme = new Ping();
            PingReply replyme = pingme.Send("ping-me.ds.on.epicgames.com", 1000);
            NaIP5.Content = "Ping : " + replyme.RoundtripTime + "ms";
            NaMS5.Content = "Address : " + replyme.Address;
            NaSTATUS5.Content = replyeu.Status;

        }





        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Process.Start("explorer", "http://github.com/vrkx/PingniteUI"); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            Task.Delay(500).Wait();
            Ping pingea = new Ping();
            PingReply replyea = pingea.Send("ping-nae.ds.on.epicgames.com", 1000); 
            NaIP.Content = "Ping : " + replyea.RoundtripTime + "ms";
            NaMS.Content = "Address : " + replyea.Address;
            NaSTATUS.Content = replyea.Status;

            Ping pingwe = new Ping();
            PingReply replywe = pingwe.Send("ping-naw.ds.on.epicgames.com", 1000);
            NaIP1.Content = "Ping : " + replywe.RoundtripTime + "ms";
            NaMS1.Content = "Address : " + replywe.Address;
            NaSTATUS1.Content = replywe.Status;

            Ping pingnac = new Ping();
            PingReply replynac = pingnac.Send("ping-nac.ds.on.epicgames.com", 1000);
            NaIP2.Content = "Ping : " + replynac.RoundtripTime + "ms";
            NaMS2.Content = "Address : " + replynac.Address;
            NaSTATUS2.Content = replynac.Status;

            Ping pingbr = new Ping();
            PingReply replybr = pingbr.Send("ping-br.ds.on.epicgames.com", 1000);
            NaIP3.Content = "Ping : " + replybr.RoundtripTime + "ms";
            NaMS3.Content = "Address : " + replybr.Address;
            NaSTATUS3.Content = replybr.Status;


            Ping pingeu = new Ping();
            PingReply replyeu = pingeu.Send("ping-eu.ds.on.epicgames.com", 1000);
            NaIP4.Content = "Ping : " + replyeu.RoundtripTime + "ms";
            NaMS4.Content = "Address : " + replyeu.Address;
            NaSTATUS4.Content = replyeu.Status;


            Ping pingme = new Ping();
            PingReply replyme = pingme.Send("ping-me.ds.on.epicgames.com", 1000);
            NaIP5.Content = "Ping : " + replyme.RoundtripTime + "ms";
            NaMS5.Content = "Address : " + replyme.Address;
            NaSTATUS5.Content = replyeu.Status;

            



        }
    }
}