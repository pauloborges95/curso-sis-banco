using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        //propriedades
        public string Titular { get; set; } // nome pode ser alterado
        public int Numero { get; private set; } //número da conta não pode ser alterado
        public double Saldo { get; private set; }//é possível ser alterado pela ação do usuário e não do progamador

        //contrutores
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
                
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular) // palavra this para reaproveitar os atirbutos
        {
            Saldo = saldo;
        }
        //métodos
        public void Deposito(double quantia) //utiliza o void porque não retorna valor
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        //é o que vai mostrar as informações na tela
        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", titular: "
                + Titular
                + ", saldo:  $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }








    }
}
