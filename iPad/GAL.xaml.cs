using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TalG__MiniProject
{
    /// <summary>
    /// Interaction logic for GAL.xaml
    /// </summary>
    public partial class GAL : Window
    {
        public GAL()
        {
            InitializeComponent();
            web.Navigated += new NavigatedEventHandler(wbMain_Navigated);
        }

        void wbMain_Navigated(object sender, NavigationEventArgs e) // Removes all the errors.
        {
            SetSilent(web, true); // make it silent
        }
        public static void SetSilent(WebBrowser browser, bool silent)
        {
            if (browser == null)
                throw new ArgumentNullException("browser");

            // get an IWebBrowser2 from the document
            IOleServiceProvider sp = browser.Document as IOleServiceProvider;
            if (sp != null)
            {
                Guid IID_IWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");
                Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");

                object webBrowser;
                sp.QueryService(ref IID_IWebBrowserApp, ref IID_IWebBrowser2, out webBrowser);
                if (webBrowser != null)
                {
                    webBrowser.GetType().InvokeMember("Silent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null, webBrowser, new object[] { silent });
                }
            }
        }
        [ComImport, Guid("6D5140C1-7436-11CE-8034-00AA006009FA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IOleServiceProvider
        {
            [PreserveSig]
            int QueryService([In] ref Guid guidService, [In] ref Guid riid, [MarshalAs(UnmanagedType.IDispatch)] out object ppvObject);
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
            web.Navigate("about:blank");                                //leaves the current site to a blank one, in order to stop the current
            MainWindow mainWin = new MainWindow();                      // closing the current window and showing the main window
            mainWin.Show();
            this.Close();
        }


        

    }
}
