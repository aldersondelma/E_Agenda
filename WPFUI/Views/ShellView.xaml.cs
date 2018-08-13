using System.Windows;
using WPFUI.ViewModels;

namespace WPFUI.Views
{
    /// <summary>
    /// Lógica interna para ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
		#region Construtor da classe
		public ShellView()
        {
            InitializeComponent();
			dataGridContato.ItemsSource = ShellViewModel.listContato;
        }
		#endregion

	}
}
