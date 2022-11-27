using Severino.ContentViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Severino.Views
{
    public partial class IndexPage : ContentPage
    {
      
        public IndexPage()
        {

            InitializeComponent();

         
            ListServices.ItemsSource = new string[]
            {
              "mono",
              "monodroid",
              "monotouch",
              "monorail",
              "monodevelop",
              "monotone",
              "monopoly",
              "monomodal",
              "mononucleosis"
            };
        }
    }
}