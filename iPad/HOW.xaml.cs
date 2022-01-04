using System;
using System.Collections.Generic;
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

namespace TalG__MiniProject
{
    /// <summary>
    /// Interaction logic for HOW.xaml
    /// </summary>
    public partial class HOW : Window
    {
        public HOW()
        {
            InitializeComponent();                                          //Start The App And Show window
        }

        private void btnGLOW2_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 1;                                           //disappears the button
        }
         
        private void btnGLOW2_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 0;                                           //appears the button 
        }

        private void btnGLOW2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWin = new MainWindow();                                             // closing the current window and showing the main window
            mainWin.Show();
            this.Close();
        }

        private void btnRPS_MouseEnter(object sender, MouseEventArgs e)
        {
            btnRPS.Source = new BitmapImage(new Uri(@"Images\Main\Apps\RPSg.png", UriKind.Relative)); // Shows selected (Glow)
        }

        private void btnRPS_MouseLeave(object sender, MouseEventArgs e)
        {
            btnRPS.Source = new BitmapImage(new Uri(@"Images\Main\Apps\RPS.png", UriKind.Relative)); // Shows app (Normal)
        }

        private void btnXO_MouseEnter(object sender, MouseEventArgs e)
        {
            btnXO.Source = new BitmapImage(new Uri(@"Images\Main\Apps\XOg.png", UriKind.Relative)); // Shows selected (Glow)
        }

        private void btnXO_MouseLeave(object sender, MouseEventArgs e)
        {
            btnXO.Source = new BitmapImage(new Uri(@"Images\Main\Apps\XO.png", UriKind.Relative)); // Shows app (Normal)
        }

        private void btnCUPS_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCUPS.Source = new BitmapImage(new Uri(@"Images\Main\Apps\CUPSg.png", UriKind.Relative)); // Shows selected (Glow)
        }

        private void btnCUPS_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCUPS.Source = new BitmapImage(new Uri(@"Images\Main\Apps\CUPS.png", UriKind.Relative)); // Shows app (Normal)
        }

        private void btnRPS_MouseDown(object sender, MouseButtonEventArgs e) // Opens Rock Paper Scissors Guide
        {
            RPSg rpsg = new RPSg();                                             
            rpsg.Show();
            this.Close();
        }

        private void btnXO_MouseDown(object sender, MouseButtonEventArgs e) // Opens Tic Tac Toe Guide
        {
            XOg xog = new XOg();
            xog.Show();
            this.Close();
        }

        private void btnCUPS_MouseDown(object sender, MouseButtonEventArgs e) // Opens Cups Guide
        {
            CUPSg cupsg = new CUPSg();
            cupsg.Show();
            this.Close();
        }
    }
}
