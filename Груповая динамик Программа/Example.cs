using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    /// <summary>
    /// Моя ветка
    /// </summary>
    public class Example
    {
        string rndWord;
        int valueFile;
        int valueFolder;

        public Example()
        {
            rndWord = "";
            valueFile = 0;
            valueFolder = 0;
        }

        public int getCountFiles() { return valueFile; }

        public string createRndExample(string path)
        {
            if (openDir(path))
            {
                Random rnd = new Random();
                valueFile = rnd.Next(10, 25);
                valueFolder = rnd.Next(2, 5);

                createRndWord();

                for (int i = 0; i < valueFile; i++)
                    createRndFiles(path);

                return rndWord;
            }
            return "";
        }

        public bool openDir(string path)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Данной директории не существует!");
                return false;
            }
            return true;
        }

        public void createRndWord()
        {
            Random rnd = new Random();
            char rndChar;
            Random rndInt = new Random();

            for (int i = rndInt.Next(7, 19); i > 0; i--)
            {
                rndChar = (char)rnd.Next('A', 'Z');
                rndWord += rndChar;
            }
        }

        bool ForCreate = false;

        public void createRndFiles(string path)
        {
            string fileName = System.IO.Path.GetRandomFileName();
            Random gen = new Random();

            if (!ForCreate)
            {
                fileName = rndWord;
                ForCreate = true;
            }
            StreamWriter sw = new StreamWriter(path + "\\" + fileName + ".txt", true);

            int str = gen.Next(15, 150);
            int sym = 0;
            int val = 0;
            char sy;
            for(int i = 0; i < str; i++)
            {
                sym = gen.Next(80, 300);
                for (int j = 0; j < sym; j++)
                {
                    if (gen.Next(1000) < 1) // в 0.1% случаев пишем наше слово
                    {
                        sw.Write(rndWord);
                        j += rndWord.Length - 1;
                    }
                    else
                    {
                        val = gen.Next(3, 12);
                        for(int k = 0; k < val; k++)
                        {
                            sy = (char)gen.Next('A', 'Z');
                            if (gen.Next(100) < 90)
                                sy = (char)((int)sy +32);
                            sw.Write(sy);
                        }
                        j += val;
                    }
                    sw.Write(' ');
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
