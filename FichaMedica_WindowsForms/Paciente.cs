using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_2B_Alg2
{
    public class Paciente
    {
        //atributos do paciente
        public string Nome {get;set;}
        public string RG { get;set;}
        public string CPF { get;set;}
        public string Telefone { get;set;}

        //Construtor da classe
        public Paciente(string nome, string rg, string cpf, string telefone)
        {
            this.Nome = nome;
            this.RG = rg;
            this.CPF = cpf;
            this.Telefone = telefone;
        }
        //método que retornárá as informações do paciente quando ele enviar a ficha
        public string RetornarInfo()
        {
            return "Nome " + this.Nome + "\nRG: " + this.RG + "\nCPF: " + this.CPF + "\nTelefone: " + this.Telefone;
        }
    }
}
