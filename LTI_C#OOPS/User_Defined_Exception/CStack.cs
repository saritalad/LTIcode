using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User_Defined_Exception
{
    class CStack
    {
         private int size;
         private int[] arr;
         private int top;

        public CStack(int size)
        {
            top = -1;
            this.size = size;
            arr = new int[this.size];
        }

        //push elements into array and throw exception if user trying to enter elements more than array size
        public void push(int element)
        {
            if (top == size-1)
            {
                throw new AllocationException("Stack Full Exception Occured"); 
            }
            arr[++top] = element;
        }

        //pop out elements from array and throw exception if user trying to pop elements more than the array size
        public int pop()
        {
            if (top <= -1)
            {
                throw new AllocationException("Stack Empty Exception Occured");
            }
            return arr[top--];
        }
    }
}
