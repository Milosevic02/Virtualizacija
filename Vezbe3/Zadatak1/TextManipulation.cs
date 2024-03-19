using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class TextManipulation:IDisposable
    {
        private TextWriter textWriter;
        private TextReader textReader;
        private bool disposed = false;
        string path = "";

        public TextManipulation(string path)
        {
            this.path = path;
        }

        public string Path { get => path;}

        ~TextManipulation()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if (textWriter != null)
                    {
                        textWriter.Dispose();
                    }
                    if(textReader != null) { 
                    
                        textReader.Dispose();
                    }
                }
                disposed = true;
            }
        }
    }
}
