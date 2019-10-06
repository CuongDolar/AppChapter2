using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppChapter2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }

        
        /*private async Task<bool> ButtonClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.Text = " It is so cool";
            return await Task.FromResult(true);
        }*/

        private void ButtonClicked(object sender, EventArgs e)
        {
            var a = sender as Button;
            a.Text = "nguyen dinh cuong";
            a.Text = a.Text.ToUpper();
        }

        private void clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArrayPage());
        }

        private void clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConstructorsPage());
        }

        private void clicked3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReferencePage());
        }

        private void clicked4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyValuesPage());
        }
    }
}