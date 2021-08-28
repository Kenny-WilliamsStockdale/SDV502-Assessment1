using CinemaApp;
using NUnit.Framework;

namespace CinemaFunctionsTest
{
    [TestFixture]
    public class TestCase1
    {
        //Adult_Before_5(int quantitiy, string person, string day, decimal time, decimal expected) 
        [TestCase(1, "adult", "Monday", 4, 14.50)]
        [TestCase(2, "adult", "Monday", 4, 29.00)]
        [TestCase(0, "adult", "Monday", 4, -1)]
        [TestCase(4, "adult", "Monday", 6, -1)]
        [TestCase(4, "adult", "Monday", 4, 58.00)]


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

    public class TestCase2
    {
        //Adult_After_5(int quantitiy, string person, string day, decimal time, decimal expected) 
        [TestCase(1, "child", "Monday", 4, -1)]
        [TestCase(2, "adult", "Sunday", 4, -1)]
        [TestCase(1, "adult", "Monday", 6, 17.50)]
        [TestCase(4, "adult", "Monday", 5, 70.00)]
        [TestCase(3, "adult", "Wednesday",7, 52.50)]


        public void Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Adult_After_5(pr_quantity, pr_person, pr_day, pr_time);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase3
    {
        //Adult_Tuesday(int quantitiy, string person, string day, decimal expected) 
        [TestCase(1, "adult", "Monday", -1)]
        [TestCase(1, "adult", "Tuesday", 13.00)]
        [TestCase(1, "senior", "Tuesday", -1)]
        [TestCase(4, "adult", "Tuesday", 52.00)]
        [TestCase(6, "adult", "Tuesday", 78.00)]


        public void Adult_Tuesday(int pr_quantity, string pr_person, string pr_day, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Adult_Tuesday(pr_quantity, pr_person, pr_day);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase4
    {
        //Adult_Tuesday(int quantitiy, string person, decimal expected) 
        [TestCase(1, "child", 12.00)]
        [TestCase(4, "child", 48.00)]
        [TestCase(1, "adult", -1)]
        [TestCase(4, "student", -1)]
        [TestCase(6, "child", 72.00)]


        public void Child_Under_16(int pr_quantity, string pr_person, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Child_Under_16(pr_quantity, pr_person);
            //assert
            Assert.That(price == expected);

        }


    }
}
