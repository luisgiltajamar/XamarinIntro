using Xamarin.Forms;

namespace DemoCanalIntroXamarinForms
{
    public partial class DemoCanalIntroXamarinFormsPage : ContentPage
    {
        private int veces = 0;

        public DemoCanalIntroXamarinFormsPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            veces++;

            lbResultado.Text = $"Has pulsado {veces} veces";
        }
    }
}
