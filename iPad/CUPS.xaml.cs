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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TalG__MiniProject
{
    /// <summary>
    /// Interaction logic for CUPS.xaml
    /// </summary>
    public partial class CUPS : Window
    {
        int rand;                                                //Define int named rand
        int Time;                                                //Define int named Time
        bool isCup1 = false;                                     //Define var that his purpose is to Tell us if the cup has been clicked 
        bool isCup2 = false;                                     //Define var that his purpose is to Tell us if the cup has been clicked 
        bool isCup3 = false;                                     //Define var that his purpose is to Tell us if the cup has been clicked 
        private DispatcherTimer MoveBall;                        //Define object Dispatchertimer named MoveBall
        public CUPS()
        {
            InitializeComponent();                               //Start The App And Show window
            Random rnd = new Random();                           //Define object Random named rnd
            rand = rnd.Next(0, 3);                               //Put random number between 0-2(include)
            Time = 0;                                            //Set Time to 0
            MoveBall = new DispatcherTimer();                    //Give MoveBall Place On the memory
            MoveBall.Interval = TimeSpan.FromMilliseconds(10);   //Breaktime before tick again(10ms)
            MoveBall.Tick += MoveBall_Tick;                      //Event Tick(Every tick what to do)
            MoveBall.Start();                                    //Start The Timer


            Cup1.IsEnabled = false;                              //set cups that canoot be clicked
            Cup2.IsEnabled = false;                              //set cups that canoot be clicked
            Cup3.IsEnabled = false;                              //set cups that canoot be clicked
        }

        private void MoveBall_Tick(object sender, EventArgs e)
        {
            if (rand == 0)                                        //Condition of the Ball that his x equals to the current cup  
                Canvas.SetLeft(Ball, Canvas.GetLeft(Cup1) + 40);  //Condition of the Ball that his x equals to the current cup
            else if (rand == 1)                                   //Condition of the Ball that his x equals to the current cup
                Canvas.SetLeft(Ball, Canvas.GetLeft(Cup2) + 40);  //Condition of the Ball that his x equals to the current cup
            else if (rand == 2)                                   //Condition of the Ball that his x equals to the current cup
                Canvas.SetLeft(Ball, Canvas.GetLeft(Cup3) + 40);  //Condition of the Ball that his x equals to the current cup
          
            if (Time == 300)                                      //Wait 3 sec and then make the cups enabled and stop timer
            {                                                     //Wait 3 sec and then make the cups enabled and stop timer
                Cup1.IsEnabled = true;                            //Wait 3 sec and then make the cups enabled and stop timer
                Cup2.IsEnabled = true;                            //Wait 3 sec and then make the cups enabled and stop timer
                Cup3.IsEnabled = true;                            //Wait 3 sec and then make the cups enabled and stop timer
                MoveBall.Stop();                                  //Wait 3 sec and then make the cups enabled and stop timer
            }                                                     //Wait 3 sec and then make the cups enabled and stop timer
            Time++;                                               //Wait 3 sec and then make the cups enabled and stop timer
        }

        private void btnGLOW2_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 1;                                 //Make Opacity 1 when mouseenter
        }

        private void btnGLOW2_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 0;                                 //Make Opacity 0 when mouseleave
        }

        private void btnGLOW2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWin = new MainWindow();                 //Go To main menu and close this window
            mainWin.Show();                                        //Go To main menu and close this window
            this.Close();                                          //Go To main menu and close this window
        }
        private void Cup3_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isCup3)                                            //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            {                                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                if (rand == 2)                                     //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Won");                    //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                else                                               //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Lost");                   //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                MainWindow main = new MainWindow();                //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                main.Show();                                       //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                this.Close();                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            }                                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
        }

        private void Cup2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isCup2)                                            //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            {                                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                if (rand == 1)                                     //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Won");                    //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                else                                               //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Lost");                   //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                                                                   //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                MainWindow main = new MainWindow();                //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                main.Show();                                       //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                this.Close();                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            }
        }

        private void Cup1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isCup1)                                            //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            {                                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                if (rand == 0)                                     //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Won");                    //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                else                                               //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                    MessageBox.Show("You Lost");                   //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                MainWindow main = new MainWindow();                //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                main.Show();                                       //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
                this.Close();                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
            }                                                      //When Cup Has Been Clicked and the mouse leaves the Cup, Check for winner 
        }
       

        private void Cup2_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            isCup2 = true;                                         //Change isCup to true when cup is clicekd
        }

        private void Cup3_MouseDown_1(object sender, MouseButtonEventArgs e)
        { 
            isCup3 = true;                                         //Change isCup to true when cup is clicekd
        }

        private void Cup1_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            isCup1 = true;                                         //Change isCup to true when cup is clicekd
        }
    }
}
