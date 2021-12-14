using System;
namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int Nconta { get; private set; } // Propriedades/Atributos da Classe
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public void Deposito(double valor) // Metodo
        {
            Saldo += valor;
        }
        public void Saque(double valor) // Metodo
        {
            Saldo -= valor - 5;
        }
        public ContaBancaria(int nconta, string nome) // Contrutor
        {
            Nconta = nconta;
            Nome = nome;
        }
    }
}
