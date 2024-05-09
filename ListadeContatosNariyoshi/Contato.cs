using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeContatosNariyoshi
{
    internal class Contato
    {
        // Declaração de variávis.
        private string nome;
        private string sobrenome;
        private string telefone;

        // Propriedades.
        // get = leitura.
        // set = definição
        // é possível ser somente leitura, ou somente definição
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }
        // Construtor de classe.
        public Contato()
        {
            Nome = "Cláudio";
            Sobrenome = "Amilton";
            Telefone = "(11 9888-4077";
        }

        // Sobrecarga de método contruto.
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome=nome;
            Sobrenome=sobrenome;
            Telefone=telefone; 
        }

        //"override" sobrescreve o método a classe pai (polimorfismo).
        public override string ToString()
        {
            // Inicializa a variável como vazia
            string saida = string.Empty;
            saida += String.Format("{0} {1}", Nome, Sobrenome);
            saida += String.Format("{0}) {1}-{ 2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(3, 5),
                Telefone.Substring(7, 4));

            return saida;
        }
    }
}
