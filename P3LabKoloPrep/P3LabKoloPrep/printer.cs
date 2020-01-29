using System;
using System.Collections.Generic;
using System.Text;

namespace P3LabKoloPrep
{
    class printer
    {
        int Pages;
        List<Ink> Inks;
        public event EventHandler OutOfPaperEvent;
        public event EventHandler<OutOfInkEventArgs> OutOfInkEvent;
        public printer(int p, List<Ink> inks)
        {
            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfInkEvent += OutOfInkEventHandler;
            OutOfPaperEvent.Invoke(this, EventArgs.Empty);
            OutOfInkEvent.Invoke(this, new OutOfInkEventArgs("bubu", 6));
        }
        

        
        private void OutOfPaperEventHandler(object obj, EventArgs args)
        {
            Console.WriteLine("No paper madafaka");
        }
        private void OutOfInkEventHandler(object obj, OutOfInkEventArgs)
        {

        }
    }
}
