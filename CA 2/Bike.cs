using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_2
{
    public enum Gender {Male, Female }
     public class Bike
    {
        //Setting The Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Gender SuitableFor { get; set; }

        //Setting Up the Constructors
        public Bike(int id, string name, decimal price, Gender gender)
        {
            ID = id;
            Name = name;
            Price = price;
            SuitableFor = gender;
        }

        //Creating The Methods
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }


    }
}
