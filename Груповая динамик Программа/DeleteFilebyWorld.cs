using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    class DeleteFilebyWorld
    {
        string Word;

        private List<string> Logs = new List<string>();

        public List<string> DeleteByWord(string start_path, string word)
        {
            if (!Directory.Exists(start_path))
            {
                MessageBox.Show("Данной директории не существует!");
                return null;
            }
            if(word == null || word.Length == 0)
            {
                MessageBox.Show("Слово поиска, пустое!");
                return null;
            }

            Word = word;

            searh_and_Delete_Files(start_path);

            return Logs;
        }

        private void searh_and_Delete_Files(string Path)
        {
            DirectoryInfo di = new DirectoryInfo(Path);

            foreach (var file in di.GetFiles())
            {
                try
                {
                    if (getFileNameWithoutExtension(file.Name) == Word)
                    {
                        String prom = file.Name;
                        file.Delete(); //MessageBox.Show("Файл : " + file.FullName + " соответствует.");
                        Logs.Add("Файл: " + prom + " был успешно удален. Причина: Соотвествие по имени.");
                    }
                    else
                        search_in_Data_File(file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    Logs.Add(ex.Message);
                }
            }
            foreach (var dir in di.GetDirectories())
                searh_and_Delete_Files(dir.FullName);
        } //Поиск название файла и поиск файлов по директориям

        private void search_in_Data_File(FileInfo file)
        {
            int CountStr = 0;
            using (StreamReader read = new StreamReader(file.FullName, false))
            {
                for (string str = ""; str != null; str = read.ReadLine(), CountStr++)
                {
                    if (Regex.IsMatch(str, @"\b" + @Word + @"\b")) //@"([\n\s]|^)" + @Word + @"([\n\s]|$)"
                    {
                        read.Close();

                        String prom = file.Name;
                        file.Delete();
                        Logs.Add("Файл: " + prom + " был успешно удален. Причина: Строка: " + CountStr + " содержит данное слово.");
                        break;
                    }
                }
            }
        } //Поиск слова в файле

        protected string getFileNameWithoutExtension(string fullFileName)
        {
            if (!Regex.IsMatch(fullFileName, @"\.")) return fullFileName; //В случае если в файле отсутсвуют точки

            String str = "";
            bool forWrite = false;

            for (int i = fullFileName.Length - 1; i >= 0; --i)
            {
                if (forWrite)
                {
                    str += fullFileName[i];
                }
                else if (fullFileName[i] == '.') forWrite = true;
            }

            char[] array = str.ToCharArray();
            Array.Reverse(array);

            return new string(array);
        } //Получить название файла без разширения


    }
}
