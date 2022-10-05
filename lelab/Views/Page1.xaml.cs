using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        int count = 0;
        public Page1()
        {
            InitializeComponent();
        }

        public void CountButtonClicked(object sender, EventArgs e)
        {
            count++;
            Cmp.Text=""+count;
            Console.WriteLine("btn cliqué ");
        }
    }
}