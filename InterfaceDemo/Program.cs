using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ISmartPhone
    {
        void OS();
        void AppStore();
    }

    interface IFeatures
    {
        void FaceRecog();
    }

    public class Apple : ISmartPhone,IFeatures
    {
        public void AppStore()
        {
            Console.WriteLine("AppStore Method: The Application Store of this smartphone is iTunes");
        }

        public void FaceRecog()
        {
            Console.WriteLine("FaceReco Method: This method provides Face Recognition  features.");
        }

        public void OS()
        {
            Console.WriteLine("OS Method: The OS of this Smartphone is iOS11");
        }
    }

    public class Samsung : ISmartPhone
    {
        public void AppStore()
        {
            Console.WriteLine("OS Method: The OS of this smartphone is Android");
        }

        public void OS()
        {
            Console.WriteLine("AppStore Method: The Application Store of this smartphone is Google Play");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("//////////////////// - Interface Demo - //////////////////// \n");
            Console.WriteLine("Apple SmartPhone:");
            Apple apple = new Apple();
            apple.OS();
            apple.AppStore();
            apple.FaceRecog();

            Console.WriteLine("\n\n");
            Console.WriteLine("Samsung SmartPhone:");
            Samsung samsung = new Samsung();
            samsung.OS();
            samsung.AppStore();
            Console.ReadKey();

            Customer customer = new Customer();
            IDebitCard debitCard = new Customer();
            ICreditCard creditCard = new Customer();
            creditCard.CardNumber();
            debitCard.CardNumber();
            Console.ReadKey();

        }
    }


    interface IDebitCard
    {
        void CardNumber();
    }

    //Second Interface ICreditCard    
    interface ICreditCard
    {
        void CardNumber();
    }

    //Customer Class implementing both the Interfaces    
    class Customer : IDebitCard, ICreditCard
    {
        void IDebitCard.CardNumber()
        {
            Console.WriteLine("Debit Card No XXXX");
        }

        void ICreditCard.CardNumber()
        {

            Console.WriteLine("Credit Card No XXXX");
        }
    }
}
