using System.Windows;

namespace TaschenrechnerWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aktuellerWert = 0;
        int letztesErgebnis = 0;
        bool zahleneingabeLäuft = true;
        char letzteRechenoperation = '=';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZifferAnhängen(int z)
        {
            if (zahleneingabeLäuft) //Wenn zahleneingabeLäuft läuft
            {
                aktuellerWert = aktuellerWert * 10 + z; //hänge weiter Zahlen hinten ran
            }
            else
            {
                aktuellerWert = z; //lasse die letzte Zahl stehen
                zahleneingabeLäuft = true; //schalte es danach auf true
            }
            textblockAusgabe.Text = aktuellerWert.ToString();
        }

        private void Button7_Click(object sender, RoutedEventArgs e) //sender = Wer darauf geklickt hat
        {
            ZifferAnhängen(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(9);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(6);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(3);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ZifferAnhängen(0);
        }
        private void Rechne(char rechenoperation)
        {
            switch (letzteRechenoperation)
            {
                case '+':
                    letztesErgebnis = letztesErgebnis + aktuellerWert;
                    break;
                case '-':
                    letztesErgebnis = letztesErgebnis - aktuellerWert;
                    break;
                case '*':
                    letztesErgebnis = letztesErgebnis * aktuellerWert;
                    break;
                case '/':
                    letztesErgebnis = letztesErgebnis / aktuellerWert;
                    break;
                case '=':
                    letztesErgebnis = aktuellerWert;
                    break;
            }
            textblockAusgabe.Text = letztesErgebnis.ToString();
            zahleneingabeLäuft = false;
            letzteRechenoperation = rechenoperation;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            Rechne('+');
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            Rechne('-');
        }

        private void ButtonMal_Click(object sender, RoutedEventArgs e)
        {
            Rechne('*');
        }

        private void ButtonGeteilt_Click(object sender, RoutedEventArgs e)
        {
            Rechne('/');
        }

        private void ButtonGleich_Click(object sender, RoutedEventArgs e)
        {
            Rechne('=');
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            aktuellerWert = 0;
            letztesErgebnis = 0;
            zahleneingabeLäuft = true;
            letzteRechenoperation = '=';
            textblockAusgabe.Text = aktuellerWert.ToString();
        }
    }
}
