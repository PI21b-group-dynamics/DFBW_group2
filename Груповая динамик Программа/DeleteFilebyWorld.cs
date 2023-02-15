using System;
using System.Collections.Generic;
using System.Drawing;
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

        public int CountDeleteFiles { get; set; }

        public List<string> DeleteByWord(string start_path, string word)
        {
            if (!Directory.Exists(start_path))
                throw new DirectoryNotFoundException("Данной дериктории не существует!");
            if (word == null || word.Length == 0)
                throw new FormatException("Слово поиска, пустое!");

            Word = word;

            searh_and_Delete_Files(start_path);

            if (CountDeleteFiles > 0)
                Logs.Add("Всего было удалено: " + CountDeleteFiles);
            else
                Logs.Add("Небыло найдено файлов соответствующий данному слову.");

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
                        DeleteFile(file, "Соотвествие по имени");
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

                        DeleteFile(file, "Содержит данное слово");
                        break;
                    }
                }
            }
        } //Поиск слова в файле

        private void DeleteFile(FileInfo file, String reason)
        {
            String NameFile = "";
            String PathFile = "";

            try
            {
                NameFile = file.Name;
                PathFile = file.FullName;
                file.Delete();

            } catch(IOException ex) 
            {
                MessageBox.Show(ex.Message);
                Logs.Add(ex.Message);
                return;
            }
            
            Logs.Add("Файл: " + NameFile + " был успешно удален. Причина: " + reason + ".");
            Logs.Add("Полный путь: " + PathFile + "\r\n");

            CountDeleteFiles++;
        }

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
