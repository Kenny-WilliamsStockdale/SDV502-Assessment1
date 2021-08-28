using CinemaApp;
using NUnit.Framework;

namespace CinemaFunctionsTest
{
    [TestFixture]
    public class TestCase1
    {
        //Adult_Before_5(int quantitiy, string person, string day, decimal time, decimal expected) 
        [TestCase(1, "Adult", "Monday", 4, 14.50)]
        [TestCase(2, "Adult", "Monday", 4, 29.00)]
        [TestCase(0, "Adult", "Monday", 4, -1)]
        [TestCase(4, "Adult", "Monday", 5, -1)]
        [TestCase(4, "Adult", "Monday", 4, 58.00)]


        public void Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);
            //assert
            Assert.That(price == expected);

        }
        

    }
}
