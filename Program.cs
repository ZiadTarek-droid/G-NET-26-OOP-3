using System.Reflection.Metadata;
using System;
using System.Security.AccessControl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a) Composition
            //A University has Departments, and if the university is closed, the departments no longer exist → strong ownership.

            //b) Association
            //A Driver uses a Car, but does not own it → simple relationship without ownership.

            //c) Inheritance
            //A Dog is an Animal → "is-a" relationship.

            //d) Aggregation
            //A Team has Players, and if the team is deleted, players still exist → weak ownership.

            //e) Dependency
            //A method receives a Logger as a parameter and only uses it inside the method → temporary usage relationship.
            #endregion

            #region Q2
            //a)
            //A child class in a different assembly cannot access a protected field unless it inherits from the parent class.
            //The protected field cannot be accessed through an object instance from outside the class hierarchy.

            //b)
            //protected internal → Accessible within the same assembly OR from derived classes in other assemblies. 
            //private protected → Accessible only within the same assembly AND only from derived classes.

            //c)
            //sealed class → Cannot be inherited.
            //sealed method → Cannot be overridden in a derived class (must already be overriding a virtual method).

            //d)
            //Yes, you can create an object from a sealed class using new.
            //The sealed keyword only prevents inheritance, not instantiation.
            #endregion

            #region PART-02
            Cinema cinema = new Cinema("IMAX Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("\nBooking Ref 1: BK-1");
            Console.WriteLine("Booking Ref 2: BK-2");

            Console.WriteLine("\nGroup Discount (5 x 100 EGP): 450 EGP (10% off)");

            cinema.CloseCinema();
        }
        #endregion
    }

    }

