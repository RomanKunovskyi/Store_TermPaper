using Bll.Abstract;
using Bll.Concrete;
using MahApps.Metro.Controls;
using MetroSample.ViewModel;

namespace MetroSample.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        string nickName;
        public MainWindow(string nickname)
        {
            MainWindowViewModel.nickname = nickname;
            InitializeComponent();
            nickName = nickname;
        }
        public void BeforeClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //IPurchaseHistoryBll Bll = new PurchaseHistoryBll(nickName);
            //Bll.GetFilteredByNameList("Null");
            //if (Bll.GetList().Count != 0)
            //    Bll.Delete(Bll.GetList()[0]);
        }
    }
    
}
