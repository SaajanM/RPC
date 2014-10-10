﻿using System;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;
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
using Windows.UI.Popups;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Pickers;
using Windows.System.UserProfile;
using System.Xml;
using System.Xml.Serialization;
using Windows.Data.Xml;
using Windows.Data.Xml.Dom;
using System.Xml.Linq;
using Windows.Data.Xml.Xsl;
using System.Xml.Schema;
using MugenInjection.Xml.Components;
using MugenInjection.Xml.Infrastructure;
using MugenInjection.Xml.Interface.Components;
using MugenInjection.Xml.Interface;
using MugenInjection.Xml.Modules;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RockPaperScissorsChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string file = null;
        string file1 = null;
        string file2 = null;
        string file3 = null;
        string file4 = null;
        string file5 = null;
        string file6 = null;
        string file7 = null;
        string file8 = null;
        string file9 = null;


        

        
        
        
        
       
        private async void are_you_ready()
        {
            var results = new MessageDialog("ARE YOU READY!", "RPC CHALLENGE");
            results.Commands.Add(new UICommand("Yes"));
            results.Commands.Add(new UICommand("No",(UICommandInvokedHandler)=>{Application.Current.Exit();}));
            await results.ShowAsync();
            
            
            
                
            
        }

        
       
        private void make_computer_choice()
        {
            
            int number = random_number_genertor.Next(3);
            if (number == 0)
            {
                computerPictureChoice.Source = rockPicture.Source;
            }
            else if (number == 1)
            {
                computerPictureChoice.Source = paperPicture.Source;
            }
            else
            {
                computerPictureChoice.Source = scissorPicture.Source;
            }
            see_who_wins();

        }

        private async void see_who_wins()
        {
            
            if (yourPictureChoice.Source == rockPicture.Source && computerPictureChoice.Source == paperPicture.Source)
            {
                lose.Play();
                var interger = Convert.ToInt32(lossesEditBox.Text);
                interger++;
                lossesEditBox.Text = interger.ToString();
                

            }
            else if (yourPictureChoice.Source == paperPicture.Source && computerPictureChoice.Source == scissorPicture.Source)
            {

                lose.Play();
                var interger = Convert.ToInt32(lossesEditBox.Text);
                interger++;
                lossesEditBox.Text = interger.ToString();
                
            }
            else if (yourPictureChoice.Source == scissorPicture.Source && computerPictureChoice.Source == rockPicture.Source)
            {

                lose.Play();
                var interger = Convert.ToInt32(lossesEditBox.Text);
                interger++;
                lossesEditBox.Text = interger.ToString();
                
            }
            else if (yourPictureChoice.Source == paperPicture.Source && computerPictureChoice.Source == rockPicture.Source)
            {

                win.Play();
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                
            }
            else if (yourPictureChoice.Source == scissorPicture.Source && computerPictureChoice.Source == paperPicture.Source)
            {

                win.Play();

                
                
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                
            }
            else if (yourPictureChoice.Source == rockPicture.Source && computerPictureChoice.Source == scissorPicture.Source)
            {
                win.Play();
               
                var interger = Convert.ToInt32(winsEditBox.Text);
                interger++;
                winsEditBox.Text = interger.ToString();
                

            }
            else if (yourPictureChoice.Source == computerPictureChoice.Source)
            {
                tie.Play();
               
                var interger = Convert.ToInt32(drawsEditBox.Text);
                interger++;
                drawsEditBox.Text = interger.ToString();
               
            }
            if (lossesEditBox.Text == wins.Text)
            {
                var results = new MessageDialog("YOU LOSE", "Results");
                results.Commands.Add(new UICommand("OK"));
               await results.ShowAsync();
            }
            else if (winsEditBox.Text == wins.Text)
            {
                var results = new MessageDialog("YOU WIN", "Results");
                results.Commands.Add(new UICommand("OK"));
              await  results.ShowAsync();
            }
            else if (drawsEditBox.Text == wins.Text)
            {
                var results = new MessageDialog("TIE", "Results");
                results.Commands.Add(new UICommand("OK"));
                await results.ShowAsync();
            }
            if (winsEditBox.Text == wins.Text || lossesEditBox.Text == wins.Text || drawsEditBox.Text == wins.Text)
            {
                var results = new MessageDialog("Would you like to exit?", "RPC CHALLENGE");
                results.Commands.Add(new UICommand("Yes", (UICommandInvokedHandler) => { Application.Current.Exit(); }));
                results.Commands.Add(new UICommand("No", (UICommandInvokedHandler) =>
                {
                    drawsEditBox.Text = "0";
                    lossesEditBox.Text = "0";
                    winsEditBox.Text = "0";
                }));
                await results.ShowAsync();
                
            
            }

        }

        Random random_number_genertor = new Random();

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            drawsEditBox.Text = "0";
            lossesEditBox.Text = "0";
            winsEditBox.Text = "0";
        }

        

        

        private void ResetClick(object sender, RoutedEventArgs e)
        {
            drawsEditBox.Text = "0";
            lossesEditBox.Text = "0";
            winsEditBox.Text = "0";
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            text.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Visible;
            text3.Visibility = Visibility.Visible;
            text4.Visibility = Visibility.Visible;
            wins.Visibility = Visibility.Visible;
            MusicOnOff.Visibility = Visibility.Visible;
            WallPaper.Visibility = Visibility.Visible;
            filepath.Visibility = Visibility.Visible;
            Ok.Visibility = Visibility.Visible;
            cyw.Visibility = Visibility.Collapsed;
            rockPicture.Visibility = Visibility.Collapsed;
            paperPicture.Visibility = Visibility.Collapsed;
            scissorPicture.Visibility = Visibility.Collapsed;
            Wins.Visibility = Visibility.Collapsed;
            Losses.Visibility = Visibility.Collapsed;
            Draws.Visibility = Visibility.Collapsed;
            winsEditBox.Visibility = Visibility.Collapsed;
            lossesEditBox.Visibility = Visibility.Collapsed;
            drawsEditBox.Visibility = Visibility.Collapsed;
            You.Visibility = Visibility.Collapsed;
            Comp.Visibility = Visibility.Collapsed;
            yourPictureChoice.Visibility = Visibility.Collapsed;
            computerPictureChoice.Visibility = Visibility.Collapsed;
            Reset.Visibility = Visibility.Collapsed;
            options.Visibility = Visibility.Collapsed;
        }
        private void filetext(object sender, TextChangedEventArgs e)
        {
            
            

            if (file == null)
            {
                file = filepath.Text;
                
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file));
                WallPaper.SelectedIndex = 5;
            }
            else if (file1 == null)
            {
                file1 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file1));
            }
            else if (file2 == null)
            {
                file2 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file2));
            }
            else if (file3 == null)
            {
                file3 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file3));
            }
            else if (file4 == null)
            {
                file4 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file4));
            }
            else if (file5 == null)
            {
                file5 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file5));
            }
            else if (file6 == null)
            {
                file6 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file6));
            }
            else if (file7 == null)
            {
                file7 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file7));
            }
            else if (file8 == null)
            {
                file8 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file8));
            }
            else if (file9 == null)
            {
                file9 = filepath.Text;
                WallPaper.Items.Add(Path.GetFileNameWithoutExtension(file9));
            }
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (MusicOnOff.SelectedIndex == 1)
            {
                win.IsMuted = true;
                lose.IsMuted = true;
                tie.IsMuted = true;
            }
         
         if (WallPaper.SelectedIndex == 0)
         {
             ImageBrush volcano=new ImageBrush();
             volcano.ImageSource = new BitmapImage(new Uri("http://content.screencast.com/users/math5/folders/Jing/media/194663ce-5425-4b50-a9bd-e52f5920c70c/2014-08-10_0943.png"));
             grid1.Background=volcano;
         }
         else if (WallPaper.SelectedIndex == 1)
         {
             ImageBrush Ocean=new ImageBrush();
             Ocean.ImageSource = new BitmapImage(new Uri("http://content.screencast.com/users/math5/folders/Jing/media/e0c34ad8-9fa2-4e09-a107-a441d31674e8/2014-08-10_0941.png"));
             grid1.Background=Ocean;
         }
         else if (WallPaper.SelectedIndex == 2)
         {
             ImageBrush sky=new ImageBrush();
             sky.ImageSource = new BitmapImage(new Uri("http://content.screencast.com/users/math5/folders/Jing/media/38ec16b0-0db1-49b5-99db-5ca53a8f592b/2014-08-10_0939.png"));
             grid1.Background=sky;
         }
         else if (WallPaper.SelectedIndex == 3)
         {
             
             
             
             ImageBrush Beach=new ImageBrush();
             Beach.ImageSource = new BitmapImage(new Uri("http://content.screencast.com/users/math5/folders/Jing/media/0939cc63-964a-40cd-baf1-ff893813370c/2014-08-10_0937.png"));
             grid1.Background=Beach;
         }
         else if (WallPaper.SelectedIndex == 4)
         {

             grid1.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(0, 0, 0, 0));
             
             
         }
         else if (WallPaper.SelectedIndex == 5)
         {
             
             ImageBrush add = new ImageBrush();
             add.ImageSource = new BitmapImage(new Uri("ms-appdata:///local/newImage.jpg"));
             grid1.Background = add;
             

             

         }
         
         text.Visibility = Visibility.Collapsed;
         text1.Visibility = Visibility.Collapsed;
         text2.Visibility = Visibility.Collapsed;
         text3.Visibility = Visibility.Collapsed;
         text4.Visibility = Visibility.Collapsed;
         wins.Visibility = Visibility.Collapsed;
         MusicOnOff.Visibility = Visibility.Collapsed;
         WallPaper.Visibility = Visibility.Collapsed;
         filepath.Visibility = Visibility.Collapsed;
         Ok.Visibility = Visibility.Collapsed;
         cyw.Visibility = Visibility.Visible;
         rockPicture.Visibility = Visibility.Visible;
         paperPicture.Visibility = Visibility.Visible;
         scissorPicture.Visibility = Visibility.Visible;
         Wins.Visibility = Visibility.Visible;
         Losses.Visibility = Visibility.Visible;
         Draws.Visibility = Visibility.Visible;
         winsEditBox.Visibility = Visibility.Visible;
         lossesEditBox.Visibility = Visibility.Visible;
         drawsEditBox.Visibility = Visibility.Visible;
         You.Visibility = Visibility.Visible;
         Comp.Visibility = Visibility.Visible;
         yourPictureChoice.Visibility = Visibility.Visible;
         computerPictureChoice.Visibility = Visibility.Visible;
         Reset.Visibility = Visibility.Visible;
         options.Visibility = Visibility.Visible;
        }

        

        

        private async void text4clicked(object sender, RoutedEventArgs e)
        {
            
            FileOpenPicker imagePicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation =PickerLocationId.Desktop,  
                FileTypeFilter = { ".jpg", ".jpeg", ".png", ".bmp" },
            };
            var MyImage = await imagePicker.PickSingleFileAsync();
            if (MyImage != null)
            {
                await MyImage.CopyAsync(ApplicationData.Current.LocalFolder,"newImage.jpg",Windows.Storage.NameCollisionOption.ReplaceExisting);
                filepath.Text = MyImage.Path;
            }
        }
        
        private async void Form1_Loaded(object sender, RoutedEventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            XmlElement child = doc.CreateElement("child");
            XmlElement back = doc.CreateElement("back");
            back.InnerText = "Volcano";
            child.AppendChild(back);
            XmlElement notillvic = doc.CreateElement("notillvic");
            notillvic.InnerText = "10";
            child.AppendChild(notillvic);
            XmlElement music = doc.CreateElement("music");
            music.InnerText = "on";
            child.AppendChild(music);
            Windows.Storage.StorageFile dt = await ApplicationData.Current.LocalFolder.CreateFileAsync("DataFile.xml", CreationCollisionOption.OpenIfExists);
            

            
            await doc.SaveToFileAsync(dt
                );
         }
       
        private void rockRealeased1(object sender, PointerRoutedEventArgs e)
        {
            yourPictureChoice.Source = rockPicture.Source;


            make_computer_choice();
        }

        private void paperRealesed1(object sender, PointerRoutedEventArgs e)
        {
            yourPictureChoice.Source = paperPicture.Source;
           
            make_computer_choice();
        }

        private void scissorsRealesed1(object sender, PointerRoutedEventArgs e)
        {
            yourPictureChoice.Source = scissorPicture.Source;
            make_computer_choice();
        }

        
            
        }
    }
