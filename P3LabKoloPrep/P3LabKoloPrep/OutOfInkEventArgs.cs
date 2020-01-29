using System;
using System.Collections.Generic;
using System.Text;

namespace P3LabKoloPrep
{
    class OutOfInkEventArgs
    {
        string Colour;
        int PageNo;
        public OutOfInkEventArgs(string colour, int pageNo)
        {
            Colour = colour;
            PageNo = pageNo;
        }
    }
}
