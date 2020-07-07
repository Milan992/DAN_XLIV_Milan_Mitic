using System.Windows;
using WpfPizzeria.ViewModels;

namespace WpfPizzeria.Views
{
    /// <summary>
    /// Interaction logic for Guest.xaml
    /// </summary>
    public partial class Guest : Window
    {
        public Guest()
        {
            InitializeComponent();
            this.DataContext = new GuestViewModel(this);
        }
    }
}
