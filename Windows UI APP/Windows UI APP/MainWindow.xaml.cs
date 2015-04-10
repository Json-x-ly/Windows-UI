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
using System.Windows.Interop;
using QRCoder;

namespace Windows_UI_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private BitmapSource Bitmap2BitmapImage(System.Drawing.Bitmap bitmap)
        {
            BitmapSource i = Imaging.CreateBitmapSourceFromHBitmap(
                           bitmap.GetHbitmap(),
                           IntPtr.Zero,
                           Int32Rect.Empty,
                           BitmapSizeOptions.FromEmptyOptions());
            return i;
        }

        private void Generate_QR_Codes(object sender, RoutedEventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(_TextBox_01.Text, QRCodeGenerator.ECCLevel.Q);
            pictureBoxQRCode.Source = Bitmap2BitmapImage(qrCode.GetGraphic(20)); ;
        }

        private void hmm(object sender, DragEventArgs e)
        {
            
        }

        private void _TextBox_01_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
