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
        [TestCase(0, "senior", "Monday", 4, -1)]
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
        [TestCase(1, "adult", "Tuesday", 4, -1)]
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
        //Child_Under_16(int quantitiy, string person, decimal expected) 
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

    public class TestCase5
    {
        //Senior(int quantitiy, string person, decimal expected) 
        [TestCase(2, "child", -1)]
        [TestCase(2, "senior", 25.00)]
        [TestCase(1, "adult", -1)]
        [TestCase(4, "senior", 50.00)]
        [TestCase(2, "student", -1)]


        public void Senior(int pr_quantity, string pr_person, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Senior(pr_quantity, pr_person);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase6
    {
        //Student(int quantitiy, string person, decimal expected) 
        [TestCase(1, "student", 14.00)]
        [TestCase(2, "senior", -1)]
        [TestCase(3, "adult", -1)]
        [TestCase(4, "student", 56.00)]
        [TestCase(2, "student", 28.00)]


        public void Student(int pr_quantity, string pr_person, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Student(pr_quantity, pr_person);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase7
    {
        //Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child, decimal expected) 
        [TestCase(1, 2, 2, 46.00)]
        [TestCase(1, 1, 3, 46.00)]
        [TestCase(2, 2, 6, 92.00)]
        [TestCase(1, 3, 1, -1)]
        [TestCase(2, 4, 4, 92.00)]


        public void Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Family_Pass(pr_quantity_ticket, pr_quantity_adult, pr_quantity_child);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase8
    {
        //Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day, decimal expected) 
        [TestCase(1, "adult", "thursday", 21.50)]
        [TestCase(1, "student", "thursday", -1)]
        [TestCase(2, "adult", "monday", -1)]
        [TestCase(2, "adult", "thursday", 43.00)]
        [TestCase(4, "adult", "thursday", 86.00)]


        public void Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Chick_Flick_Thursday( pr_quantity, pr_person, pr_day);
            //assert
            Assert.That(price == expected);

        }


    }

    public class TestCase9
    {
        //Kids_Careers(int pr_quantity, string pr_day, bool pr_holiday, decimal expected) 
        [TestCase(1, "thursday", false, -1)]
        [TestCase(1, "wednesday", false, 12.00)]
        [TestCase(2, "wednesday", true, -1)]
        [TestCase(2, "wednesday", false, 24.00)]
        [TestCase(5, "wednesday", false, 60.00)]


        public void Kids_Careers(int pr_quantity, string pr_day, bool pr_holiday, decimal expected)
        {
            //arange
            TicketPriceController TPC = new();
            //act
            decimal price = TPC.Kids_Careers(pr_quantity, pr_day, pr_holiday);
            //assert
            Assert.That(price == expected);

        }


    }
}
