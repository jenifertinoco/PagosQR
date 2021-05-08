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
    public partial class Recargar : ContentPage
    {
        public Recargar()
        {
            InitializeComponent();
        }

        private void btnRecargarSaldo_Clicked(object sender, EventArgs e)
        {

        }
    }
}