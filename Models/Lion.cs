using System;

namespace AbstractExample.Models
{
    public class Lion : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Lion says ROAR");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lion is sleeping");
        }
    }
}