using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BookEventArgs
    {
        private string title;
        private int oldScore;
        private int newScore;

        public string Title { get { return title; } set { title = value; } }
        public int OldScore { get { return oldScore; } set { oldScore = value; } }
        public int NewScore { get { return newScore; } set { newScore = value; } }

        public BookEventArgs(string title, int oldScore, int newScore)
        {
            this.title = title;
            this.oldScore = oldScore;
            this.newScore = newScore;
        }
    }
}
