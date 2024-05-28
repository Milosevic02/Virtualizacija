using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LibrarySubscriber
    {
        public void OnRatingChanged(object sender, BookEventArgs e)
        {
            Console.WriteLine($"Book {e.Title} score changed from {e.OldScore} to {e.NewScore} ");
        }
    }
}
