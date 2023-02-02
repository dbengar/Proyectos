using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DI_UT2_PRACT1_Campeonato
{
    /// <summary>
    /// Lógica de interacción para partido.xaml
    /// </summary>
    /// 


    public partial class partido : UserControl
    {
        //atributos
        public bool PartidoJugado = false;


        public string ganador = "";


        public partido()
        {
            
            InitializeComponent();
        }


        public bool CargarDatosPartido (string fecha, string equLocal, string equVisitante)
        {
            bool valueReturn = false;
            if (!PartidoJugado)
            {
                LblFechaPartido.Content = fecha;
                LblEquipo1.Content = equLocal;
                LblEquipo2.Content = equVisitante;
                valueReturn = true;
            }


            return valueReturn;
        }

        public void resetarPartido()
        {
            LblFechaPartido.Content = "Fecha del partido";
            LblEquipo1.Content = "Equipo 1";
            LblEquipo2.Content = "Equipo 2";
            TxtBoxEquipo1.Text = "";
            TxtBoxEquipo2.Text = "";
            LblEquipo1.Background = new SolidColorBrush(Colors.LightGray);
            LblEquipo2.Background = new SolidColorBrush(Colors.LightGray);
            BtnResultado.Content = "Confirmar partido";
            PartidoJugado = false;
            TxtBoxEquipo1.IsEnabled = true;
            TxtBoxEquipo2.IsEnabled = true;

        }

        private void BtnResultado_Click(object sender, RoutedEventArgs e)
        {
           

            if (!PartidoJugado){

                    Validacion(TxtBoxEquipo1,TxtBoxEquipo2,LblEquipo1,LblEquipo2);
            }
            else
            {
                cancelarPartido(LblEquipo1,LblEquipo2,TxtBoxEquipo1,TxtBoxEquipo2);
            }
                

        }

        private void Validacion(TextBox textBox1,TextBox textBox2, Label e1, Label e2)
        {
            int resultadoPartido;
            bool esNumerico = Int32.TryParse(TxtBoxEquipo2.Text, out resultadoPartido);
            bool esNumerico1 = Int32.TryParse(TxtBoxEquipo1.Text, out resultadoPartido);
            
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (!esNumerico && !esNumerico1)
                {
                    MessageBox.Show("Los valores de los campos tienen que ser numericos", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {

                    int resultado1 = int.Parse(TxtBoxEquipo1.Text);
                    int resultado2 = int.Parse(TxtBoxEquipo2.Text);

                    
                    if (resultado1 > resultado2)
                    {
                        ganador = (string)e1.Content;
                        e1.Background = new SolidColorBrush(Colors.LightGreen);
                        e2.Background = new SolidColorBrush(Colors.LightSalmon);
                        PartidoJugado = true;
                        textBox2.IsEnabled = false;
                        textBox1.IsEnabled = false;
                        BtnResultado.Content = "Cancelar Partido";

                    }
                    else if (resultado2 > resultado1)
                    {
                        ganador = (string)e2.Content;
                        e2.Background = new SolidColorBrush(Colors.LightGreen);
                        e1.Background = new SolidColorBrush(Colors.LightSalmon);
                        PartidoJugado = true;
                        textBox2.IsEnabled = false;
                        textBox1.IsEnabled = false;
                        BtnResultado.Content = "Cancelar Partido";
                    }
                    else
                    {
                        MessageBox.Show("Los equipos no pueden quedar empate", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }
        }
        private void cancelarPartido(Label e1, Label e2, TextBox textBox1, TextBox textBox2)
        {
            if (PartidoJugado)
            {

                if (MessageBox.Show("¿Seguro que quiere cancelar el partido?", "Cancelar Partido", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    e1.Background = new SolidColorBrush(Colors.LightGray);
                    e2.Background = new SolidColorBrush(Colors.LightGray);
                    PartidoJugado = false;
                    textBox1.IsEnabled = true;
                    textBox2.IsEnabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    BtnResultado.Content = "Confirmar Resultado";
                }
            }
        }
    }


}
