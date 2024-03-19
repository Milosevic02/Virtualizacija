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

        public void AddTextToFile(string text)
        {
            textWriter = File.AppendText(path);
            textWriter.WriteLine(text);
            textWriter.Close();
        }

        public string ReadAllText()
        {
            textReader= File.OpenText(path);
            string text = textReader.ReadToEnd();
            textReader.Close();
            return text;
        }

        public void DeleteText()
        {
            File.WriteAllText(path,string.Empty);
        }

        public Dictionary<string,int> CountWordsInText(params string[] args)
        {
            Dictionary<string,int>words = new Dictionary<string,int>();
            foreach(string word in args)
            {
                words.Add(word, 0);
            }

            string[] allWords = ReadAllText().Replace("\r\n", " ").Replace("\r", " ").Split(' ');
            foreach(string word in allWords)
            {
                foreach (string key in words.Keys)
                {
                    if(word == key)
                    {
                        words[key]++;
                    }
                }
            }
            return words;

        }
    }
}
