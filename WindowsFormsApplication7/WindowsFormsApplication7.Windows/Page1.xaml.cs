using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RockPaperScissorsChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }
        public MainPage page;
        public void beforeformif()
        {
            if (page == null)
            {
                page = new MainPage();
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public string Wins
        {
            get
            {
              return  wins.Text;
            }
        }

        private void Form2_Load(object sender, RoutedEventArgs e)
        {
            beforeformif();
            
        }

        public void Options_Click()
        {
            this.IsEnabled = true;
            
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void filetext(object sender, TextChangedEventArgs e)
        {

        }

      





        
    }
}
