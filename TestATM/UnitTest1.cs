using ATM;

namespace TestATM
{
    public class UnitTest1
    {
        
        public void ReturnCurrentBalance()
        {
            //Arrange
            Program.Balance = 10000;
            
            //Act
            decimal balance = Program.ViewBalance();

            //Assert
            Assert.Equal(10000, balance);
        }
        [Fact]
       
        //Test Withdraw valid input
        public void TestWithdraw_AmountLessThanBalance()
        {
            //Arrange
            Program.Balance = 10000;
            decimal amount1 =6000 ;

            //Act
            decimal balance1 = Program.Withdraw(amount1);

            //Assert
            Assert.Equal(4000, balance1);
        }

        //Test withdraw invalid (amount > balance)
        [Fact]
        public void TestWithdraw_AmountLargerthanBalance()
        {
            //Arrange
            Program.Balance = 10000;
            decimal amount2 = 20000;

            //Act
            decimal balance2=Program.Withdraw(amount2);

            //Assert
            Assert.Equal(10000, balance2);
        }

        //Test withdraw invalid (amount < 0)
        public void TestWithdraw_AmountLessthanZero()
        {
            //Arrange
            Program.Balance = 10000;
            decimal amount3 = -2000;

            //Act
            decimal balance3= Program.Withdraw(amount3);

            //Assert
            Assert.Equal(10000, balance3);
        }

        //Test deposit valid
        public void TestDeposit_amountLargerThanZero()
        {
            Program.Balance = 10000;
            decimal amount4 = 300;

            decimal balance4= Program.Deposit(amount4);

            Assert.Equal(10400, balance4);
        }

        //Test deposit invalid
        public void TestDeposit_amountLessThanZero()
        {
            Program.Balance = 10000;
            decimal amount5 = -300;

            decimal balance5 = Program.Deposit(amount5);

            Assert.Equal(10000, balance5);
        }

    }
}