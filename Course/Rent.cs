using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Rent
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int Room { get; set; }

        public Rent()
        {
           
        }

        public Rent(string name, string email, int room) {
            this.Name = name;
            this.Email = email;
            this.Room = room;   
        }

    }
}
