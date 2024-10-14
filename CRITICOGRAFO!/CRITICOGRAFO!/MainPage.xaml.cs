using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRITICOGRAFO_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGeneroChanged(object sender, CheckedChangedEventArgs e)
        {
            if (HombreRadio.IsChecked)
            {
                AltoLabel.Text = "Alto";
                FeoLabel.Text = "Feo";
                ListoLabel.Text = "Listo";
                ExtravaganteLabel.Text = "Extravagante";
                RaroLabel.Text = "Raro";
                GrandeLabel.Text = "Grande";
            }
            else if (MujerRadio.IsChecked)
            {
                AltoLabel.Text = "Alta";
                FeoLabel.Text = "Fea";
                ListoLabel.Text = "Lista";
                ExtravaganteLabel.Text = "Extravagante"; 
                RaroLabel.Text = "Rara";
                GrandeLabel.Text = "Grande"; 
            }
        }
        private void OnCriticarClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string genero = "";
            if (HombreRadio.IsChecked)
                genero = "Hombre";
            else if (MujerRadio.IsChecked)
                genero = "Mujer";
            List<string> atributos = new List<string>();
            if (AltoCheckBox.IsChecked) atributos.Add(AltoLabel.Text);
            if (FeoCheckBox.IsChecked) atributos.Add(FeoLabel.Text);
            if (ListoCheckBox.IsChecked) atributos.Add(ListoLabel.Text);
            if (ExtravaganteCheckBox.IsChecked) atributos.Add(ExtravaganteLabel.Text);
            if (RaroCheckBox.IsChecked) atributos.Add(RaroLabel.Text);
            if (GrandeCheckBox.IsChecked) atributos.Add(GrandeLabel.Text);

            string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nAtributos: {string.Join(", ", atributos)}";

            DisplayAlert("Critica", mensaje, "CERRAR");
        }
    }
}
