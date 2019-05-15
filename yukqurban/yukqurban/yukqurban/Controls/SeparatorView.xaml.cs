using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yukqurban.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeparatorView : ContentView
	{
        private static readonly BindableProperty bgColorProperty = BindableProperty.Create(nameof(bgColor), typeof(Color), typeof(SeparatorView), (Color)App.Current.Resources["MainColor"]);
        private static readonly BindableProperty SeparatorHeightProperty = BindableProperty.Create(nameof(SeparatorHeight), typeof(int), typeof(SeparatorView), 1);

        public Color bgColor
        {
            get => (Color)GetValue(bgColorProperty);
            set => SetValue(bgColorProperty, value);
        }

        public int SeparatorHeight
        {
            get => (int)GetValue(SeparatorHeightProperty);
            set => SetValue(SeparatorHeightProperty, value);
        }

        public SeparatorView ()
		{
			InitializeComponent ();

            BindingContext = this;
		}
	}
}