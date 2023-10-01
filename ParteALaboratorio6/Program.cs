using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    /// 
    public class Calculadora
    {
        private int num1;
        private int num2;

        private Calculadora() { }

        public Calculadora(int numero1, int numero2)
        {
            num1 = numero1;
            num2 = numero2;
        }

        public int NUME1
        {
            get { return num1; }
        }

        public int NUME2
        {
            get { return num2; }
        }

        public int suma()
        {
            int respuesta = num1 + num2;
            return respuesta;
        }

        public int multiplicacion()
        {
            int respuesta = num1 * num2;
            return respuesta;
        }

        public int resta()
        {
            int respuesta = num1 - num2;
            return respuesta;
        }

        public int division()
        {
            int respuesta = num1 / num2;
            return respuesta;
        }

        public int mod()
        {
            int respuesta = num1 % num2;
            return respuesta;
        }
    }

    //EJEMPLO EN CLASE
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount; // intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}