using System.Windows;
using Caliburn.Micro;
using WPFUI.ViewModels;

namespace WPFUI
{
    class Bootstrapper : BootstrapperBase
    {
		#region Implementação da classe
		/// <summary>
		/// Construtor da classe.
		/// </summary>
		public Bootstrapper()
        {
			Initialize();
        }

		/// <summary>
		/// Definir a Janela Inicial.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
            ShellViewModel.listContato.Add(new Models.ContatoModel("Marc-Alder", "Delma", "19983863229", "marc.delma@mymail.com"));
			ShellViewModel.listContato.Add(new Models.ContatoModel("Gabriel M.", "Ribeiro", "19944442222", "mazurco066@mymail.com"));
			ShellViewModel.listContato.Add(new Models.ContatoModel("Wesley Y.", "Teodoro", "19955554489", "wyorran@mymail.com"));
			ShellViewModel.listContato.Add(new Models.ContatoModel("Alexsander", "Matzner", "19966987423", "alexsandermatzner@mymail.com"));
		}
		#endregion
	}
}
