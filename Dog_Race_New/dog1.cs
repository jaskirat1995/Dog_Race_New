using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_New
{
    public class dog1
    {
        Random rd = new Random();
        // this method is used to help the dog first to move from one position to another by using the run function 
        public int run(int start,int end) {
            return rd.Next(start, end);
        }

        //this code is used to return the value of the winner 
        public int winner(int position) {
            if (position > 830)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

    }
}
