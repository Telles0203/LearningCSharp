using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixaxaoBanco
{
    internal class ContaBancaria
    {
        private int _cadastroConta;
        private string _nomeTitular;
        private double _saldo;
        private double _deposito;
        private double _sacar;




        public int GetCadastroConta()
        {
            return _cadastroConta;
        }

        public void SetCadastroConta(int cadastroConta)
        {
            _cadastroConta = cadastroConta;
        }

        public string GetNomeTitular()
        {
            return _nomeTitular;
        }
        public void SetNomeTitular(string nomeTitular)
        {
            _nomeTitular = nomeTitular;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double saldo)
        {
            _saldo = saldo;
        }


        public void SetDeposito(double deposito)
        {
            _deposito = deposito;
        }

        public double GetDeposito()
        {
            return _deposito;
        }

        public void SetSacar(double sacar)
        {
            _sacar = sacar+5;
        }

        public double ValorEmConta(int opcao)
        {
            if (opcao == 1)
            {
                _saldo += _deposito;
            }
            else if (opcao == 2)
            {
                _saldo += _deposito;
            }
            else if (opcao == 3)
            {
                _saldo -= _sacar;
            }
            Console.WriteLine($"\nDados da conta:\n" +
                $"Conta: {_cadastroConta}, Titular: {_nomeTitular}, Saldo: R$ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}\n");
            
            return _saldo;
        }
    }
}
