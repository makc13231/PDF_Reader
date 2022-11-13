using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Media;
using static System.Net.WebRequestMethods;
/*TODO...
* ++ #1.1. Допилить трёхпоточный поиск(когда поток закончил, он берёт следующий в очереди файл, а не каждый третий)
* ++ #1.2. Добавить выбор между вариантами через чекбоксы
* ++++++++ #1.3. Даже добился больше чем трёхпоточности
* +- #3.  Добавить сверху "Выбрать путь", "О программе"
* ++ #4.  Добавить открытие файла сразу с FileSort
* ++ #5.  Добавить выбор между поиском до первого вхождения или во всём файле
* ++ #6.  Добавить возможность искать больше 1-го слова за раз
* +- #7.  Сделать красиво
* ++ #8.  Добавить возможность читать и горизонтальные изображения/пдф-ы
* ++ #9.  Добавить возможность выбрать "мягкий", точный и ++без учёта РеГиСтРа вид поиска
* -- #10. Добавить выбор radiobatton-ами показа "элементов показа информации"
*         (вкл-выкл таймер,тек. страницу, прогрессбар)
* ++ #11. Добавить выбор прохода сразу с несколькими разрешениями PDF
*      800x600
*      1280x720
*      1600x900
*      1920x1080
* ++ #12. Добавить прогрессбар
* ++ #13. Добавить примерное время до конца
*/

namespace PDF_JPG_Reader
{
    public partial class MainForm : Form
    {
        int pageProgressValue = 0;
        int pageProgressValueETA = 0;
        int ETATimeHelper = 0;
        int flows = 3;
        bool isSearch = false;
        string[] nameFileIO3 = new string[3];
        string[] pageFileIO3 = new string[3];
        string[] resFileIO3 = new string[3];
        int fileCounter3 = 0;
        bool[] finished3 = { false, false, false };
        IList<string>[] fileSortFilesIO3 = { new List<string>(), new List<string>(), new List<string>() };

        DateTime dt;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        string[] allfiles;
        public MainForm()
        {
            InitializeComponent();
            t.Interval = 100;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (isSearch)
            {
                if (Progress.Value <= pageProgressValue * 100)
                {
                    Progress.Value = (pageProgressValue * 100 <= Progress.Maximum)? pageProgressValue * 100: Progress.Maximum;
                }
                else if (Progress.Value - Progress.Maximum / FilesAll.Items.Count / 10 >= 0) Progress.Value -= Progress.Maximum / FilesAll.Items.Count / 10;
                else Progress.Value = 0;
                foreach (IList<string> FSFIO in fileSortFilesIO3)
                    foreach (string file in FSFIO)
                        if (!FilesSort.Items.Contains(file))
                            FilesSort.Items.Add(file);
                FilePage0.Text = pageFileIO3[0];
                FileNow0.Text = nameFileIO3[0];
                Resolution0.Text = resFileIO3[0];
                FilePage1.Text = pageFileIO3[1];
                FileNow1.Text = nameFileIO3[1];
                Resolution1.Text = resFileIO3[1];
                FilePage2.Text = pageFileIO3[2];
                FileNow2.Text = nameFileIO3[2];
                Resolution2.Text = resFileIO3[2];
                int time = (int)(DateTime.Now - dt).TotalSeconds;
                if (pageProgressValueETA != pageProgressValue)
                {
                    ETATimeHelper = (int)(DateTime.Now - dt).TotalSeconds;
                    pageProgressValueETA = pageProgressValue;
                }
                int ETATime = pageProgressValue == 0 ? 0 : (ETATimeHelper/ pageProgressValue * (Progress.Maximum/100 - pageProgressValue + 1) + ETATimeHelper - time);
                ETA.Text = $"{ETATime / 60 / 60 % 60:00}:{ETATime / 60 % 60:00}:{(ETATime % 60>0? ETATime % 60 : 0):00}";
                TimerLabel.Text = $"{time / 60 / 60 % 60:00}:{time / 60 % 60:00}:{time % 60:00}";
                if (finished3[0] && finished3[1] && finished3[2])
                {
                    t.Stop();
                    FileNow0.Text = "...";
                    FilePage0.Text = "...";
                    Resolution0.Text = "...";
                    FileNow1.Text = "...";
                    FilePage1.Text = "...";
                    Resolution1.Text = "...";
                    FileNow2.Text = "...";
                    FilePage2.Text = "...";
                    Resolution2.Text = "...";
                    Search.Enabled = true;
                    SetFolder.Enabled = true;
                    Word.Enabled = true;
                    MainMenu.Enabled = true;
                    FilesSort.SelectionMode = SelectionMode.One;
                    isSearch = false;
                    fileCounter3 = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        nameFileIO3[i] = "...";
                        pageFileIO3[i] = "...";
                        finished3[i] = false;
                    }
                    Progress.Value = Progress.Maximum;
                    var sop = new SoundPlayer("C:\\Windows\\Media\\Windows User Account Control.wav");
                    sop.Play();
                    sop.Dispose();
                    MessageBox.Show("Закончено");
                    t.Start();
                }
            }
        }
        //Грейданулся с одной в N
        void FuncSearch3(int flow, int resolution)
        {
            fileSortFilesIO3[flow] = new List<string>();
            isSearch = true;
            while (fileCounter3 < allfiles.Length)
            {
                var Word4Soft = Word.Text.ToLower();
                if (SearchSoftTSMI.Checked)
                {
                    Word4Soft = Word4Soft.Replace('0', 'о');
                    Word4Soft = Word4Soft.Replace('а', 'о');
                    Word4Soft = Word4Soft.Replace('3', 'З');
                    Word4Soft = Word4Soft.Replace('и', 'н');
                    Word4Soft = Word4Soft.Replace('л', 'п');
                    Word4Soft = Word4Soft.Replace('ш', 'щ');
                    Word4Soft = Word4Soft.Replace(',', '.');
                    Word4Soft = Word4Soft.Replace(';', ':');
                    Word4Soft = Word4Soft.Replace('\"', '\'');
                }
                string file = allfiles[fileCounter3];
                fileCounter3++;
                Document pdfDocument = new Document(file);
                nameFileIO3[flow] = file.Split('\\')[file.Split('\\').Length - 1];
                bool found = false;
                int pagesProcessed = 0;
                foreach (ToolStripMenuItem item in ResolutionForTesseractMenuTSMI.DropDownItems)
                {
                    if (item.Checked)
                    {
                        pageProgressValue -= pagesProcessed;
                        pagesProcessed = 0;
                        foreach (var page in pdfDocument.Pages)
                        {
                            string resOfPage = item.Text.Split('x')[page.ArtBox.Height > page.ArtBox.Width ? 1 : 0] + "x" + item.Text.Split('x')[page.ArtBox.Height > page.ArtBox.Width ? 0 : 1];
                            pageFileIO3[flow] = page.Number.ToString();
                            resFileIO3[flow] = item.Text;
                            new PngDevice(int.Parse(resOfPage.Split('x')[0]), int.Parse(resOfPage.Split('x')[1]), new Resolution(resolution)).Process(page, $"ImageToProcess3Flow{flow}.png");
                            var ocrengine = new TesseractEngine(@".\tessdata", "rus", EngineMode.Default);
                            var img = Pix.LoadFromFile($"ImageToProcess3Flow{flow}.png");
                            var res = ocrengine.Process(img);
                            img.Dispose();
                            var text = res.GetText();
                            if (SearchRegTSMI.Checked) text = text.ToLower();
                            if (SearchSoftTSMI.Checked)
                            {
                                text = text.Replace('0', 'о');
                                text = text.Replace('а', 'о');
                                text = text.Replace('3', 'З');
                                text = text.Replace('и', 'н');
                                text = text.Replace('л', 'п');
                                text = text.Replace('ш', 'щ');
                                text = text.Replace(',', '.');
                                text = text.Replace(';', ':');
                                text = text.Replace('\"', '\'');
                            }
                            if (FindMultipleWordsTSMI.Checked)
                            {
                                foreach (string word in Word.Text.Split(';'))
                                    if (text.Contains(word) ||
                                        (text.Contains(word.ToLower()) && SearchRegTSMI.Checked) ||
                                        (text.Contains(Word4Soft.ToLower()) && SearchSoftTSMI.Checked))
                                    {
                                        fileSortFilesIO3[flow].Add($"{nameFileIO3[flow]}\\ на странице {page.Number} найдено слово {Word4Soft} с разрешением {resOfPage}");
                                        found = true;
                                        break;
                                    }
                            }
                            else
                            {
                                if (text.Contains(Word.Text) ||
                                    (text.Contains(Word.Text.ToLower()) && SearchRegTSMI.Checked) ||
                                    (text.Contains(Word4Soft.ToLower()) && SearchSoftTSMI.Checked))
                                {
                                    fileSortFilesIO3[flow].Add($"{nameFileIO3[flow]}\\ на странице {page.Number} с разрешением {resOfPage}");
                                    found = true;
                                }
                            }
                            res.Dispose();
                            ocrengine.Dispose();
                            pageProgressValue++;
                            pagesProcessed++;
                            if (found && !SearchTheEntireFileTSMI.Checked) break;
                        }
                    }
                    if (found && !SearchTheEntireFileTSMI.Checked) break;
                }
                if (!found && pdfDocument.Pages.Count>4)
                    fileSortFilesIO3[flow].Add($"{nameFileIO3[flow]}\\(!!!) внимание, возможно файл содержит то, что вы ищёте, перепроверьте вручную");
                pageProgressValue += (pdfDocument.Pages.Count>4?4:pdfDocument.Pages.Count) - pagesProcessed;
                pdfDocument.Dispose();
            }
            finished3[flow] = true;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            pageProgressValue = 0;
            Progress.Value = 0;
            FilesSort.Items.Clear();
            FilesSort.SelectionMode = SelectionMode.None;
            MainMenu.Enabled = false;
            Search.Enabled = false;
            SetFolder.Enabled = false;
            Word.Enabled = false;
            dt = DateTime.Now;
            //N-поточный поиск
            for(int i = 0; i < 3; i++)
            {
                if (i < flows)
                {
                    Task.Run(() => FuncSearch3(i, 300));
                    Thread.Sleep(50);
                }
                else
                {
                    finished3[i] = true;
                }
            }
        }

        private void FilesSort_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FilesSort.IndexFromPoint(e.Location) != -1)
                try
                {
                    Process.Start(Folder.SelectedPath + @"\" + FilesSort.SelectedItem.ToString().Split('\\')[0]);
                }
                catch
                {
                    var sop = new SoundPlayer("C:\\Windows\\Media\\Windows Background.wav");
                    sop.Play();
                    sop.Dispose();
                    MessageBox.Show("Ошибка");
                }
        }

        private void SetFolder_Click(object sender, EventArgs e)
        {
            if(Folder.ShowDialog() == DialogResult.OK)
            {
                pageProgressValue = 0;
                labelIn.Text = "Поиск из " + Folder.SelectedPath;
                allfiles = Directory.GetFiles(Folder.SelectedPath, "*.pdf");
                FilesSort.Items.Clear();
                FilesAll.Items.Clear();
                int allPagesFoProgressBar = 0;
                foreach (string file in allfiles)
                {
                    Document X = new Document(file);
                    allPagesFoProgressBar += (X.Pages.Count < 5) ? X.Pages.Count : 4;
                    string f = file.Split('\\')[file.Split('\\').Length-1];
                    FilesAll.Items.Add(f);
                }
                Word.Enabled = true;
                Progress.Maximum = allPagesFoProgressBar*100;
            }
        }

        private void Word_TextChanged(object sender, EventArgs e)
        {
            if (Word.Text.Length == 0) Search.Enabled = false;
            else Search.Enabled = true;
        }

        private void SettedFlows_Click(object sender, EventArgs e)
        {
            flows = int.Parse(((ToolStripMenuItem)sender).Text);
            FlowsTabView.TabPages.Clear();
            foreach (ToolStripMenuItem item in SetFlowsTSMI.DropDownItems)
            {
                item.Checked = flows == int.Parse(item.Text);
            }
            if (flows > 0)
                FlowsTabView.TabPages.Add(Flow0);
            if (flows > 1)
                FlowsTabView.TabPages.Add(Flow1);
            if (flows > 2)
                FlowsTabView.TabPages.Add(Flow2);
        }

        private void TSMI_Check_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            if (SearchSoftTSMI.Checked) SearchRegTSMI.Checked = true;
        }

        private void AboutTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа умеет распознавать файлы типа .pdf и" +
                "сканировать их, проверяя наличие в файле введённых слов",
                "PDF-Ищейка приветствует вас!");
            MessageBox.Show("Возможности:" +
                "\n-Поиск более 1-го слова в файле" +
                "\n-Обработка до 3-х файлов одновременно" +
                "\n-Поиск слов(-а) до первого вхождения (быстрее)" +
                "\n-Поиск слов(-а) во всём файле (медленнее)" +
                "\n-Распознование и горизонтальных, и вертикальных страниц" +
                "\n-В общей сложности 3 режима поиска: мягкий, точный, без учёта регистра" +
                "\n-Выбор качества обработки страниц документов",
                "PDF-Ищейка приветствует вас!");
            MessageBox.Show("Инструкция:" +
                "\n-Выбрать папку, в которой храняться pdf-файлы, в которых нужно найти какой-либо текст" +
                "\n-Вписать слово или его часть, которую нужно найти, в текстовую строку" +
                "\n-Произвести донастройки при необходимости" +
                "\n-Нажать кнопку \"Найти\"" +
                "\n-После поиска можно нажать на найденый файл в контейнере справа, чтобы он открылся",
                "PDF-Ищейка приветствует вас!");
            var sop = new SoundPlayer("C:/Windows/Media/Windows Notify Calendar.wav");
            sop.Play();
            sop.Dispose();
            MessageBox.Show("В названии файлов не должно быть ''\\''! Иначе, при нажатии на него, он не будет открываться",
                "Внимание!");
            MessageBox.Show("Если что-то не было понятно или вы забыли- наведите указателем на обьект",
                "");
            MessageBox.Show("Автор проекта: Воробьёв М.С. (LuciusTheEternal)\n VK: lucifer666ex",
                "Об авторе");
        }
    }
}
