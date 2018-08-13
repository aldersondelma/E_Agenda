using System.Collections.Generic;
using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    class ShellViewModel :Conductor<object>
    {
		#region Atributos
		private string _nome;
		private string _sobrenome;
		private string _telefone;
		private string _email;
		public static List<ContatoModel> listContato = new List<ContatoModel>();
		ContatoModel contato;
		#endregion

		#region Propriedades
		public string Nome {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                NotifyOfPropertyChange(() => Nome);
                NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
		
		public string Sobrenome {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
                NotifyOfPropertyChange(() => Sobrenome);
                NotifyOfPropertyChange(() => NomeCompleto);
            }
        }

        public string NomeCompleto {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }

        public string Telefone {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
                NotifyOfPropertyChange(() => Telefone);
            }
        }

        public string Email {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }
		#endregion

		#region Funções
		/// <summary>
		/// Função para salvar os registros.
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="sobrenome"></param>
		/// <param name="telefone"></param>
		/// <param name="email"></param>
		public void Save(string nome, string sobrenome, string telefone, string email)
        {
			contato = new ContatoModel(nome, sobrenome, telefone, email);
			listContato.Add(contato);
			Clear(nome, sobrenome, telefone, email);
			//Message.SetAttach(null,"");
        }
		/// <summary>
		/// Função para limpar os campos.
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="sobrenome"></param>
		/// <param name="telefone"></param>
		/// <param name="email"></param>
        public void Clear(string nome, string sobrenome, string telefone, string email)
        {
            _nome = _sobrenome = _telefone = _email = null;
            NotifyOfPropertyChange(() => Nome);
            NotifyOfPropertyChange(() => Sobrenome);
            NotifyOfPropertyChange(() => NomeCompleto);
            NotifyOfPropertyChange(() => Telefone);
			NotifyOfPropertyChange(() => Email);
        }
		/// <summary>
		/// Verificar se os campos foram preenchidos antes de salvar.
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="sobrenome"></param>
		/// <param name="telefone"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		public bool CanSave(string nome, string sobrenome, string telefone, string email)
		{
			return !string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(sobrenome) &&
				!string.IsNullOrWhiteSpace(telefone) && !string.IsNullOrWhiteSpace(email);
		}
		/// <summary>
		/// Verificar se houve pelo menos um campo preenchido.
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="sobrenome"></param>
		/// <param name="telefone"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		public bool CanClear(string nome, string sobrenome, string telefone, string email)
		{
			return !string.IsNullOrWhiteSpace(nome) || !string.IsNullOrWhiteSpace(sobrenome) ||
				!string.IsNullOrWhiteSpace(telefone) || !string.IsNullOrWhiteSpace(email);
		}
		/// <summary>
		/// Encerrar a aplicação.
		/// </summary>
        public void EndApp()
        {
            App.Current.Shutdown();
        }
		#endregion
	}
}
