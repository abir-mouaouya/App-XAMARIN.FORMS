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
    public partial class menu : ContentPage
    {
        public menu()
        {
            InitializeComponent();
        }

        public void ToCountPage(object sender, EventArgs e)
        {
            Console.WriteLine("bchwiya");
            this.Navigation.PushAsync(new Page1());
        }

        public void ToTabsPage(object sender, EventArgs e)
        {
            Console.WriteLine("bchwiya");
            this.Navigation.PushAsync(new TabsPage());
        }

        public void ToListPage(object sender, EventArgs e)
        {
            Console.WriteLine("bchwiya");
            this.Navigation.PushAsync(new ListPage());
        }
    }
}