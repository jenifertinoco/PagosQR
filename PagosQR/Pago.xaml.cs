using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagosQR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pago : ContentPage
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void bntEscanear_Clicked(object sender, EventArgs e)
        {

        }
    }
}