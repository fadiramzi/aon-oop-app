using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AonHelloWorld.Interfaces;

namespace AonHelloWorld.Models
{
    public abstract class User : IUserAuthOperations,IUserPrintOperations
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        protected int Id { get; set; }

        public void DisplayProfile()
        {
            Console.WriteLine("Implemnted from IUserPrintOperations Interface!");
        }
        

        public abstract void Login();


        public abstract void Logout();



    }
}
