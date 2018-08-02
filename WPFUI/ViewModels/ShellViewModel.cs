using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    class ShellViewModel :Screen
    {
        private string _nome;
        public static List<ContatoModel> listContato = new List<ContatoModel>();
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
        private string _sobrenome;

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

        private string _telefone;

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

        private string _email;

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

        public void Save()
        {
            ContatoModel contato;
            contato = new ContatoModel(Nome, Sobrenome, Telefone, Email);
            listContato.Add(contato);
            //Clear();

            //Message.SetAttach(null,"");
        }

        public void Clear()
        {
            _nome = _sobrenome = _telefone = _email = "";
            NotifyOfPropertyChange(() => Nome);
            NotifyOfPropertyChange(() => Sobrenome);
            NotifyOfPropertyChange(() => NomeCompleto);
            NotifyOfPropertyChange(() => Telefone);
            NotifyOfPropertyChange(() => Email);
        }
        public void EndApp()
        {
            App.Current.Shutdown();
        }
    }
}
