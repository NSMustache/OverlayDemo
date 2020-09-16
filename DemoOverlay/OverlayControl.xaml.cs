using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoOverlay
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OverlayControl
    {
        public OverlayControl()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ActionButton.Text = ActionButton.Text == "Play" ? "Pause" : "Play";
        }
    }
}