using System.Reflection.Metadata;
using System;

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
        }
    }
}
