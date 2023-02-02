using System;
using System.Collections;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    {
        bool campeonato=false;// Comprobacion de campeonato iniciado
        string datosPalmares;
        ArrayList campeonatosJugados = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            if (campeonato)
            {
                if (MessageBox.Show("El campeonato está iniciado, ¿Seguro  que quiere empezar de nuevo?", "Cancelar Campeonato", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    resetearCampeonato();
                    inicio();
                   
                }

            }
            else
            {
                inicio();
            }
        }

       

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (!campeonato)
            {
                MessageBox.Show("No se puede actualizar el campeonato ya que no ha iniciado", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {   //Comprobamos si  estamos en las semifinales
                if(Cuarto1.PartidoJugado && Cuarto2.PartidoJugado && Cuarto3.PartidoJugado && Cuarto4.PartidoJugado &&!Semi1.PartidoJugado && !Semi2.PartidoJugado)
                {
                    //Activamos los partidos
                    Semi1.IsEnabled = true;
                    Semi2.IsEnabled = true;

                   


                    //Guardamos los ganadores de los  cuartos
                    string semi1Eq1 = Cuarto1.ganador;
                    string semi1Eq2 = Cuarto2.ganador;
                    string semi2Eq1 = Cuarto3.ganador;
                    string semi2Eq2 = Cuarto4.ganador;
                   
                    //Añadimos los equipos a las semifinales
                    Semi1.LblEquipo1.Content = semi1Eq1;
                    Semi1.LblEquipo2.Content = semi1Eq2;
                    Semi2.LblEquipo1.Content = semi2Eq1;
                    Semi2.LblEquipo2.Content = semi2Eq2;

                //Comprobamos si estamos en la final
                }else if(Semi1.PartidoJugado && Semi2.PartidoJugado && !Final.PartidoJugado)
                {


                        //Desactivamos los cuartos para que no se puedan modificar
                        Cuarto1.IsEnabled = false;
                        Cuarto2.IsEnabled = false;
                        Cuarto3.IsEnabled = false;
                        Cuarto4.IsEnabled = false;
                        //Activamos el partido
                        Final.IsEnabled = true;

                        //Guardamos los gannadores de  las semifinales
                        string finalEq1 = Semi1.ganador;
                        string finalEq2 = Semi2.ganador;


                        //Añadimos los equipos a los label del partido
                        Final.LblEquipo1.Content = finalEq1;
                        Final.LblEquipo2.Content = finalEq2;
                    
                }else if(Final.IsEnabled == true)
                {

                    if (MessageBox.Show("¿Está seguro de que desea finalizar el campeonato ? Una vez finalizado no podrá modificar los resultados de los mismos.", "FINAL", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        //Si ya se ha jugado la final mandamos un mensaje de enhorabuena al equipo ganador
                         MessageBox.Show("ENHORABUENA A EL" + Final.ganador + " ERES EL EQUIPO QUE HA GANADO EL " + LblCampeonato.Content);
                        datosPalmares = LblCampeonato.Content + ":" + Final.ganador;
                        campeonatosJugados.Add(datosPalmares);
                        Final.IsEnabled = false;
                        

                        //Desactivamos las semifianles para que no se puedan modificar
                        Semi1.IsEnabled = false;
                        Semi2.IsEnabled = false;
                    }
                    

                }
                else if( Final.PartidoJugado)
                {
                    MessageBox.Show("ENHORABUENA A EL " + Final.ganador + " ERES EL EQUIPO QUE HA GANADO EL " + LblCampeonato.Content);

                }
                else
                {
                    MessageBox.Show("No se puede actualizar los datos hasta que todos los partidos de la ronda estén jugados","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }

        private void BntPalmares_Click(object sender, RoutedEventArgs e)
        {

            string lista = "";
            if (!string.IsNullOrEmpty(lista))
            {
                foreach (Object obj in campeonatosJugados)
                {
                    lista = lista + (string)obj + "\n";

                }
                MessageBox.Show(lista, "Palmares Historico", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MessageBox.Show("No existen datos de campeonatos","Información",MessageBoxButton.OK, MessageBoxImage.Information);
            }



        }

        public void resetearCampeonato()
        {
            Cuarto1.resetarPartido();
            Cuarto2.resetarPartido();
            Cuarto3.resetarPartido();
            Cuarto4.resetarPartido();
            Semi1.resetarPartido();
            Semi2.resetarPartido();
            Final.resetarPartido();
            LblCampeonato.Content = "Mi Campeonato";
            Cuarto1.IsEnabled = true;
            Cuarto2.IsEnabled = true;
            Cuarto3.IsEnabled = true;
            Cuarto4.IsEnabled = true;
            Semi1.IsEnabled = false;
            Semi2.IsEnabled = false;
            Final.IsEnabled = false;

            Cuarto1.PartidoJugado = false;
            Cuarto2.PartidoJugado = false;
            Cuarto3.PartidoJugado = false;
            Cuarto4.PartidoJugado = false;
            Semi1.PartidoJugado = false;
            Semi2.PartidoJugado = false;
            Final.PartidoJugado = false;
        }

        
        private void inicio()
        {
            //Habilitamos los cuartos con esta funcion no haria falta el metodo habilitarPartido
            Cuarto1.IsEnabled = true;
            Cuarto2.IsEnabled = true;
            Cuarto3.IsEnabled = true;
            Cuarto4.IsEnabled = true;

            campeonato = true;
            //Informacion de los partidos
            LblCampeonato.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del campeonato", "Nombre Campeonato", "Campeonato");
            Cuarto1.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
            Cuarto1.LblEquipo1.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del primer equipo del primer cuarto", "Primer equipo del primer cuarto", "Equipo 1");
            Cuarto1.LblEquipo2.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del segundo equipo del primer cuarto", "Segundo equipo del primer cuarto", "Equipo 2");

            Cuarto2.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
            Cuarto2.LblEquipo1.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del primer equipo del segundo cuarto", "Primer equipo del segundo cuarto", "Equipo 1");
            Cuarto2.LblEquipo2.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del segundo equipo del segundo cuarto", "Segundo equipo del segundo cuarto", "Equipo 2");

            Cuarto3.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
            Cuarto3.LblEquipo1.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del primer equipo del tercero cuarto", "Primer equipo del tercero cuarto", "Equipo 1");
            Cuarto3.LblEquipo2.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del segundo equipo del tercero cuarto", "Segundo equipo del tercero cuarto", "Equipo 2");

            Cuarto4.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
            Cuarto4.LblEquipo1.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del primer equipo del cuarto cuarto", "Primer equipo del cuarto cuarto", "Equipo 1");
            Cuarto4.LblEquipo2.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del segundo equipo del cuarto cuarto", "Segundo equipo del cuarto cuarto", "Equipo 2");

            //Preguntamos la fecha de las semifinal
            Semi1.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
            Semi2.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");

            //Preguntamos la fecha de la final
            Final.LblFechaPartido.Content = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha del partido", "Fecha", "Fecha");
        }

    }

}
