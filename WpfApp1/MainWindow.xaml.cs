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
using System.IO;
using HelixToolkit.Wpf;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gyongy> gyongyok = new();
        public MainWindow()
        {
            InitializeComponent();
            File.ReadAllLines("gyongyok.txt").Skip(1).ToList().ForEach(line => gyongyok.Add(new Gyongy(line)));
            foreach (Gyongy gyongy in gyongyok)
            {
                EllipsoidVisual3D gyongy3D = new();
                gyongy3D.RadiusX = gyongy3D.RadiusY = gyongy3D.RadiusZ = gyongy.E;
                gyongy3D.Center = new System.Windows.Media.Media3D.Point3D(gyongy.X * 3.5, gyongy.Y * 3.5, gyongy.Z * 3.5);
                gyongy3D.Fill = new SolidColorBrush(Colors.Black);
                ter.Children.Add(gyongy3D);
            }
        }

        //public List<Gyongy> UtvonalKereses()
        //{
        //    return gyongyok;
        //}
    }
}