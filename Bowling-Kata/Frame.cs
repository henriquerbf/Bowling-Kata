using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Kata
{
    public class Frame
    {
        private int[] RollPinsDow;

        public Frame(int qtyRolls)
        {
            RollPinsDow = new int[qtyRolls];
        } 
    }
}
