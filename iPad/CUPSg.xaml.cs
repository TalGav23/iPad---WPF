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
    /// Interaction logic for CUPSg.xaml
    /// </summary>
    public partial class CUPSg : Window
    {
        public CUPSg()
        {
            InitializeComponent();                                          //Start The App And Show window
        }

        private void btnGLOW2_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 1;                                           //appears the button 
        }

        private void btnGLOW2_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGLOW2.Opacity = 0;                                           //disappears the button
        }

        private void btnGLOW2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HOW how = new HOW();                                             // closing the current window and showing the main window
            how.Show();
            this.Close();
        }
    }
}
