using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MosEnergo2._0
{
    internal class WordHelper
    {
        private FileInfo _fileInfo;
        public string dateP;
        public string adress;
        public string flat;

        // Поиск шаблона
        public WordHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("Файл не найден");
            }
        }

        // Составления документа по найденому шаблону
        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                // Замена шаблона на данные
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                // Сохранения документа
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string defaultFileName = "Счет на " + dateP + " " + adress + ", " + flat + ".docx";
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (folderBrowserDialog.SelectedPath != null)
                    {
                        savePath = folderBrowserDialog.SelectedPath;
                    }
                }

                Object newFileName = Path.Combine(savePath, defaultFileName);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                app?.Quit();
            }

            return false;
        }
    }
}
