using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AonHelloWorld.Models
{
    public class Freelancer : User
    {

        public string Skills { get; set; }


        public override void DisplayProfile()
        {
            Console.WriteLine($"Overrided Method in Freelancer Class")
        }

    }


}
