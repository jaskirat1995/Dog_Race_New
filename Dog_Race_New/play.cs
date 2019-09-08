using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_New
{
    // abstract class that is used to declare the function without working so thus that can be accessed from further class by using the concept the 
    // inheritance of single level inheritance 
    abstract class test {
        public virtual int move(int x, int y) {
            return 0;
        }
        public int resetDog() {
            return 0;
        }


    }
    // here is the code to inherit the abstract class and  define the working of the abstract class of the method 
    class play : test
    {
        // creating the object of  the random class that is used to generate the random no to move the position of the class 
        Random Instance = new Random();
        public int move(int x,int y) {
            return Instance.Next(x, y);
        }
        // reset the position  of the dog
        public int resetTheDog() {
                return 0;
        }

    }
}
