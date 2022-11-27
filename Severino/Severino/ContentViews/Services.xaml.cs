using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Severino.ContentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Services : ContentView
	{
		public string Title { get; set; }
		public ImageSource IconImageSource { get; set; }
		public Color IconBackgroundColor { get; set; }
		public Color BorderColor { get; set; }
		public Color CardColor { get; set; }


		public Services ()
		{
			InitializeComponent ();
		}
	}
}