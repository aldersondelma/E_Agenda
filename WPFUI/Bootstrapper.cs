using System.Windows;
using Caliburn.Micro;
using WPFUI.ViewModels;

namespace WPFUI
{
    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
            //ShellViewModel.listContato.Add(new Models.ContatoModel("Marc-Alder", "Delma", "19983863229", "marc.delma@mymail.com"));
        }
    }
}
