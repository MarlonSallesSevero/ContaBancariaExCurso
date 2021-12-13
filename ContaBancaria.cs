using System;
namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int Nconta { get; private set; } // Propriedades/Atributos da Classe
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public double Deposito(double valor) // Metodo
        {
            Saldo = valor + Saldo;
            return Saldo;
        }
        public double Saque(double valor) // Metodo
        {
            Saldo = (Saldo - valor) - 5;
            return Saldo;
        }
        public ContaBancaria(int nconta, string nome) // Contrutor
        {
            Nconta = nconta;
            Nome = nome;
        }
    }
}
