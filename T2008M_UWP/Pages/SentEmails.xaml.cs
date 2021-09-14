using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SentEmails : Page
    {
        public StackPanel allEmailsPanel;
        
        public SentEmails()
        {
            this.InitializeComponent();
            allEmailsPanel = new StackPanel();
            allEmailsPanel.HorizontalAlignment = HorizontalAlignment.Left;
            allEmailsPanel.VerticalAlignment = VerticalAlignment.Top;

           
        }

        public Border GetMyBorder(int left, int top, int right, int bottom)
        {
            Border myBorder = new Border();
            myBorder.BorderThickness = new Thickness(left, top, right, bottom);
            myBorder.Padding = new Thickness(10);
            myBorder.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            return myBorder;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

            TextBlock email= new TextBlock();
            TextBlock title = new TextBlock();
            TextBlock content = new TextBlock();
            email.TextWrapping = TextWrapping.Wrap;
            title.TextWrapping = TextWrapping.Wrap;
            content.TextWrapping = TextWrapping.Wrap;

            email.Text = "Email Nhận: " + inputEmail.Text;
            title.Text = "Tiêu đề: " + inputTitle.Text;
            content.Text = "Nội dung: " + inputContent.Text;

            StackPanel emailPanel = new StackPanel();
            emailPanel.HorizontalAlignment = HorizontalAlignment.Left;
            emailPanel.VerticalAlignment = VerticalAlignment.Top;
            emailPanel.Margin = new Thickness(0, 0, 0, 20);

            Border emailBorder = GetMyBorder(2, 2, 2, 0);
            emailBorder.Child = email;
            Border titleBorder = GetMyBorder(2, 2, 2, 0);
            titleBorder.Child = title;
            Border contentBorder = GetMyBorder(2, 2, 2, 2);
            contentBorder.Child = content;
            emailPanel.Children.Add(emailBorder);
            emailPanel.Children.Add(titleBorder);
            emailPanel.Children.Add(contentBorder);
            emailPanel.Width = 500;
            
           
            allEmailsPanel.Children.Insert(0, emailPanel);

            scrollViewer.Content = allEmailsPanel;
        }
    }
}
