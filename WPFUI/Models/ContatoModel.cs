using System.Text;

namespace WPFUI.Models
{
    public class ContatoModel
    {
		#region Implementação da classe
		/// <summary>
		/// Atributos da classe
		/// </summary>
		//public int id { get { return id; } set { id = value; } }
		public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
		public string nomeCompleto { get { return $"{nome} {sobrenome}"; } }

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="sobrenome"></param>
		/// <param name="telefone"></param>
		/// <param name="email"></param>
		public ContatoModel(/*int id, */string nome, string sobrenome, string telefone, string email)
        {
            //this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.email = email;
        }
		
		/// <summary>
		/// A sobrescrita do método ToString da lasse
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(nomeCompleto)
                   .Append(", ")
                   .Append(telefone)
                   .Append(", ")
                   .Append(email);
            return builder.ToString();
        }
		#endregion
	}
}
