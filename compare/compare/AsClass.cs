using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    public class AsClassA
    {
        public AsClassA()
        {
            Name = "default";
        }
        public string Name;
    }
    public class AsClassD : AsClassA
    {
        public void Milk()
        {
            Console.WriteLine("Milk!");
        }
        public void MilkCow(AsClassA myAnimal)
        {
            AsClassD myCow = myAnimal as AsClassD;
            if (myCow != null)
                myCow.Milk();
            else
                Console.WriteLine($"{myAnimal.Name} isn't a cow, and so can't be milked.");
        }
    }
}
