using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    class IntNode
    {
        //prop tab tab
        //moze i propfull, svejedno, ovde data oba primera da znate
        public int Data { get; set; }


        //propfull tab tab
        private IntNode next;
        public IntNode Next
        {
            get { return next; }
            set { next = value; }
        }

        #region ctors

        public IntNode(int data = 0)
        {
            this.Data = data;

        }

        public IntNode(int data, IntNode next)
        {
            Data = data;
            Next = next;
        }
        #endregion

    }
}
