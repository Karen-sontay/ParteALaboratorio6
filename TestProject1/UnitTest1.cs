
using BankAccountNS;
using Moq;
using System.Diagnostics.CodeAnalysis;

namespace TestProject1
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [Fact]
        public void Calculadora_Suma_ObtenerResultadoCorrecto()
        {
            //Arr
            int numero1 = 5;
            int numero2 = 7;
            int esperado = 12;

            //Act
            Calculadora calculadora = new Calculadora(numero1, numero2);
            int resultado = calculadora.suma();

            //Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Calculadora_Multiplicacion_ObtenerResultadoCorrecto()
        {
            //Arr
            int numero1 = 5;
            int numero2 = 7;
            int esperado = 35;

            //Act
            Calculadora calculadora = new Calculadora(numero1, numero2);
            int resultado = calculadora.multiplicacion();

            //Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Calculadora_Resta_ObtenerResultadoCorrecto()
        {
            //Arr
            int numero1 = 7;
            int numero2 = 5;
            int esperado = 2;

            //Act
            Calculadora calculadora = new Calculadora(numero1, numero2);
            int resultado = calculadora.resta();

            //Assert
            Assert.Equal(esperado, resultado);
        }


        [Fact]
        public void Calculadora_Division_ObtenerResultadoCorrecto()
        {
            //Arr
            int numero1 = 16;
            int numero2 = 2;
            int esperado = 8;

            //Act
            Calculadora calculadora = new Calculadora(numero1, numero2);
            int resultado = calculadora.division();

            //Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Calculadora_Mod_ObtenerResultadoCorrecto()
        {
            //Arr
            int numero1 = 5;
            int numero2 = 3;
            int esperado = 2;

            //Act
            Calculadora calculadora = new Calculadora(numero1, numero2);
            int resultado = calculadora.mod();

            //Assert
            Assert.Equal(esperado, resultado);
        }

        //EJEMPLOS DE CLASE
        [Fact]
        public void BankAccount_CustomerName_GateTheSameNameSentToTheConstructor()
        {
            //Arr
            string TestCustomer = It.IsAny<string>();

            //Act
            BankAccount bankAccount = new BankAccount(TestCustomer, It.IsAny<double>());
            string result = bankAccount.CustomerName;

            //Assect
            Assert.Equal(TestCustomer, result);

        }

        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.Equal(expected, actual);
        }

    }
}

