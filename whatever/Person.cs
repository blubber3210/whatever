using System;
using System.Collections.Generic;
using System.Text;

namespace whatever
{
    internal class Person
    {
        public Person(string name, bool hasHealthyKdiney, bool isAlive)
        {
            Name = name;
            HasHealthyKdiney = hasHealthyKdiney;
            IsAlive = isAlive;
        }

        public string Name { get; set; }
        public bool HasHealthyKdiney { get; set; }
        public bool IsAlive { get; set; }

        public void DonateKidney(Person recipient)
        {
            var rand = new Random();
            recipient.HasHealthyKdiney = true;
        }

        public void RecieveKidney(Kidney kidney)
        {

        }

        public void CheckSurvival()
        {

        }
    }
}
