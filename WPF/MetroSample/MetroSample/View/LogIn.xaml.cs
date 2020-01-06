using MahApps.Metro.Controls;
using Visitor;

namespace MetroSample.View
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : MetroWindow
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            try
            {
                VisitorObj visitor = new VisitorObj(Loggin.Text, Password.Password);
                MainWindow mainWindow = new MainWindow(Loggin.Text);
                this.Hide();
                mainWindow.ShowDialog();
                this.Show();
            }
            catch
            {
                  Password.Password = null;
            }
            finally
            {
                  Password.Password = null;
            }
        }
    }
}
