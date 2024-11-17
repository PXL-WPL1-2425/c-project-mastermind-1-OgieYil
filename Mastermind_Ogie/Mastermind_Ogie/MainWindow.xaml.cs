using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mastermind_Ogie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateRandomCode();
        }

        private void GenerateRandomCode()
        {
            // Beschikbare kleuren
            string[] kleuren = { "rood", "geel", "oranje", "wit", "groen", "blauw" };

            // Willekeurig vier kleuren kiezen
            Random random = new Random();
            string[] randomCode = Enumerable.Range(0, 4)
                                            .Select(x => kleuren[random.Next(kleuren.Length)])
                                            .ToArray();

            // Code als string samenstellen
            string code = string.Join(", ", randomCode);

            // Toon de code in de titel van het venster
            this.Title = "De code is: " + code;
        }
    }
}