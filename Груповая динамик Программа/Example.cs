using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    public class Example
    {
        private string rndWord;
        private int valueFile;
        private int valueFolder;

        public int CountFiles { get; set; }
        public int CountDirectory { get; set; }

        public Example()
        {
            rndWord = "";
            valueFile = 0;
            valueFolder = 0;
        }

        public string createRndExample(string path)
        {
            if (Directory.Exists(path))
            {
                Random rnd = new Random();
                valueFile = rnd.Next(10, 40);
                valueFolder = rnd.Next(2, 5);

                createRndWord();

                createRndFiles(path);

                //for (int i = 0; i < valueFile; i++)
                //    createRndFiles(path);

                createRndDirectrory(path, 0);

                //for (int i = 0; i < valueFolder; i++)
                //    createRndDirectrory(path);

                return rndWord;
            }
            else 
                throw new DirectoryNotFoundException("Данной дериктории не существует!");

            return "";
        }

        private void createRndWord()
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

        //bool ForCreate = false;

        private void createRndFiles(string path)
        {
            if (CountFiles >= 130) return;

            string fileName = "";
            Random gen = new Random();

            int Count = gen.Next(0, 100);
            if (Count <= 30)
            {
                String RandExpansion = "";
                int RandSizeExpansion = gen.Next(2, 5);
                for (int i = 0; i < RandSizeExpansion; ++i)
                    RandExpansion += (char)gen.Next('a', 'z');

                fileName = rndWord + "." + RandExpansion;
                //ForCreate = true;
            } else
            {
                fileName = System.IO.Path.GetRandomFileName();

                for (int l = 0; File.Exists(path + @"\" + fileName); l++)
                    fileName = Path.GetRandomFileName();
            }

            StreamWriter sw = new StreamWriter(path + "\\" + fileName, true);

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

            CountFiles++;

            if (gen.Next(0, 100) < 30)
            {
                createRndFiles(path);
            }
        }
        private void createRndDirectrory(string path, int count_nesting)
        {
            if (count_nesting > 3 || CountDirectory >= 15) return;

            Random gen = new Random();
            string spath;
            for (int i = gen.Next(2, 5); i > 0; i--)
            {
                spath = path + "\\" + createRndWord("");

                for(int l = 0; Directory.Exists(spath) && l < 1000; l++)
                {
                    spath = path + "\\" + createRndWord("");

                    if (l + 1 == 1000)
                        return;
                }


                Directory.CreateDirectory(spath);
                createRndFiles(spath);


                CountDirectory++;

                if (gen.Next(0, 100) <= 25)
                {
                    createRndDirectrory(spath, ++count_nesting);
                }
            }
        }
        protected string createRndWord(string result)
        {
            Random rnd = new Random();
            for (int i = rnd.Next(2, 19); i > 0; i--)
                result += (char)rnd.Next('a', 'z'); ;
            return result;
        }

    }
}
