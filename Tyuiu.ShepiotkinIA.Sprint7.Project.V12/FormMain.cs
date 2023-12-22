using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint7.Project.V12.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        //СОЗДАНИЕ ТАБЛИЦЫ
        private DataTable ReadFile_SIA(string pathToCsvFile)
        {
            //таблица
            DataTable dt = new DataTable();
            //колонки
            DataColumn colAVM_SIA;
            colAVM_SIA = new DataColumn("ЭВМ", typeof(String));
            DataColumn colProd_SIA;
            colProd_SIA = new DataColumn("Изготовитель", typeof(String));
            DataColumn colCPU_SIA;
            colCPU_SIA = new DataColumn("Процессор", typeof(String));
            DataColumn colRAM_SIA;
            colRAM_SIA = new DataColumn("Объём ОЗУ", typeof(String));
            DataColumn colHaDr_SIA;
            colHaDr_SIA = new DataColumn("Тип жёсткого диска", typeof(String));
            DataColumn colHaDrVo_SIA;
            colHaDrVo_SIA = new DataColumn("Объём жёсткого диска", typeof(String));
            DataColumn colYear_SIA;
            colYear_SIA = new DataColumn("Год выпуска ЭВМ", typeof(Int32));
            dt.Columns.AddRange(new DataColumn[] { colAVM_SIA, colProd_SIA, colCPU_SIA, colRAM_SIA, colHaDr_SIA, colHaDrVo_SIA, colYear_SIA });
            //Автоматическая регулировка ширины столбцов таблицы
            dataGridViewPC_SIA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Редактирование таблицы
            dataGridViewPC_SIA.EditMode = DataGridViewEditMode.EditOnEnter;
            try
            {
                DataRow dr = null;
                string[] ivmValues = null;
                string[] ivm = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < ivm.Length; i++)
                {
                    if (!String.IsNullOrEmpty(ivm[i]))
                    {
                        ivmValues = ivm[i].Split(';');
                        dr = dt.NewRow();
                        dr["ЭВМ"] = ivmValues[0];
                        dr["Изготовитель"] = ivmValues[1];
                        dr["Процессор"] = ivmValues[2];
                        dr["Объём ОЗУ"] = ivmValues[3];
                        dr["Тип жёсткого диска"] = ivmValues[4];
                        dr["Объём жёсткого диска"] = ivmValues[5];
                        dr["Год выпуска ЭВМ"] = int.Parse(ivmValues[6]);
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        //О ПРОГРАММЕ
        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            FormAboutInfo formAboutInfo = new FormAboutInfo();
            formAboutInfo.ShowDialog();
        }
        //РУКОВОДСТВО
        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            FormAboutHelp formAboutHelp = new FormAboutHelp();
            formAboutHelp.ShowDialog();
        }
        //ОТКРЫТЬ ТАБЛИЦУ
        private void buttonOpen_SIA_Click(object sender, EventArgs e)
        {
            dataGridViewPC_SIA.DataSource = ReadFile_SIA(@"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint7\Tyuiu.ShepiotkinIA.Sprint7.Project.V12\bin\Debug\InPutFileV12.csv");
        }
        //СОХРАНИТЬ ТАБЛИЦУ
        private void buttonSave_SIA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_SIA.FileName = "OutPutFileV12.csv";
            saveFileDialogTask_SIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_SIA.ShowDialog();

            string path = saveFileDialogTask_SIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewPC_SIA.RowCount;
            int columns = dataGridViewPC_SIA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewPC_SIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewPC_SIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
        //ЧТЕНИЕ КОМПЛЕКТУЮЩИХ ПК
        private void buttonPcCheck_SIA_Click(object sender, EventArgs e)
        {
            FormAboutPcCheck FormAboutPcCheck = new FormAboutPcCheck();
            FormAboutPcCheck.ShowDialog();
        }
        //СТАТИСТИКА ТАБЛИЦЫ
        private void buttonStat_SIA_Click(object sender, EventArgs e)
        {
            //Жёсткие диски
            int hddCount = 0;
            int ssdCount = 0;
            //Озу память
            int EightGB = 0;
            int SixteenGB = 0;
            int ThirtyTwoGB = 0;
            //Объём жёсткого диска
            int FiftySix = 0;
            int Twelve = 0;
            int One = 0;
            int Two = 0;
            //Производитель
            int MSI = 0;
            int Lenovo = 0;
            int HYPERPC = 0;
            int HUAWEI = 0;
            int HP = 0;
            int ARDOR = 0;
            int DEXP = 0;
            int ASUS = 0;
            //Процессор
            int IThree = 0;
            int IFive = 0;
            int ISeven = 0;

            foreach (DataGridViewRow row in dataGridViewPC_SIA.Rows)
            {
                //Тип жёсткого диска
                if (row.Cells["Тип жёсткого диска"].Value != null)
                {
                    if (row.Cells["Тип жёсткого диска"].Value.ToString() == "HDD")
                    {
                        hddCount++;
                    }
                    else if (row.Cells["Тип жёсткого диска"].Value.ToString() == "SSD")
                    {
                        ssdCount++;
                    }
                }
                //Объём ОЗУ
                if (row.Cells["Объём ОЗУ"].Value != null)
                {
                    if (row.Cells["Объём ОЗУ"].Value.ToString() == "8 GB")
                    {
                        EightGB++;
                    }
                    else if (row.Cells["Объём ОЗУ"].Value.ToString() == "16 GB")
                    {
                        SixteenGB++;
                    }
                    else if (row.Cells["Объём ОЗУ"].Value.ToString() == "32 GB")
                    {
                        ThirtyTwoGB++;
                    }
                }
                //Объём жёсткого диска
                if (row.Cells["Объём жёсткого диска"].Value != null)
                {
                    if (row.Cells["Объём жёсткого диска"].Value.ToString() == "256 GB")
                    {
                        FiftySix++;
                    }
                    else if (row.Cells["Объём жёсткого диска"].Value.ToString() == "512 GB")
                    {
                        Twelve++;
                    }
                    else if (row.Cells["Объём жёсткого диска"].Value.ToString() == "1000 GB")
                    {
                        One++;
                    }
                    else if (row.Cells["Объём жёсткого диска"].Value.ToString() == "2000 GB")
                    {
                        Two++;
                    }
                }
                //Изготовитель
                if (row.Cells["Изготовитель"].Value != null)
                {
                    if (row.Cells["Изготовитель"].Value.ToString() == "MSI")
                    {
                        MSI++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "Lenovo")
                    {
                        Lenovo++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "HYPERPC")
                    {
                        HYPERPC++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "HUAWEI")
                    {
                        HUAWEI++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "HP")
                    {
                        HP++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "ARDOR")
                    {
                        ARDOR++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "ASUS")
                    {
                        ASUS++;
                    }
                    else if (row.Cells["Изготовитель"].Value.ToString() == "DEXP")
                    {
                        DEXP++;
                    }
                }
                //Процессор
                if (row.Cells["Процессор"].Value != null)
                {
                    if (row.Cells["Процессор"].Value.ToString() == "Intel Core i3-12100" || row.Cells["Процессор"].Value.ToString() == "Intel Core i3-10105")
                    {
                        IThree++;
                    }
                    else if (row.Cells["Процессор"].Value.ToString() == "Intel Core i5-13400F" || row.Cells["Процессор"].Value.ToString() == "Intel Core i5-11400F" || row.Cells["Процессор"].Value.ToString() == "Intel Core i5-10400" || row.Cells["Процессор"].Value.ToString() == "Intel Core i5-12400F")
                    {
                        IFive++;
                    }
                    else if (row.Cells["Процессор"].Value.ToString() == "Intel Core i7-13700KF" || row.Cells["Процессор"].Value.ToString() == "Intel Core i7-14700KF")
                    {
                        ISeven++;
                    }
                }
            }
            textBoxStat_SIA.Text = $"----------------ИЗГОТОВИТЕЛИ----------------\r\nMSI: { MSI}\r\nLenovo: { Lenovo}\r\nHYPERPC: { HYPERPC}\r\nHUAWEI: { HUAWEI}\r\nHP: {HP}\r\nARDOR: {ARDOR}\r\nASUS: {ASUS}\r\nDEXP: {DEXP}" +
                $"\r\n-----------------ПРОЦЕССОРЫ-----------------\r\nIntel core i3: {IThree}\r\nIntel core i5: {IFive}\r\nIntel core i7: {ISeven}" +
                $"\r\n------------------ПАМЯТЬ ОЗУ--------------------\r\nRAM 8 GB: {EightGB}\r\nRAM 16 GB: {SixteenGB}\r\nRAM  32 GB: {ThirtyTwoGB}" +
                $"\r\n----------------------HDD/SSD-----------------------\r\nHDD: {hddCount}\r\nSSD: {ssdCount}" +
                $"\r\n----------------ОБЪЁМ HDD/SSD---------------\r\nHDD/SSD 256 GB: {FiftySix}\r\nHDD/SSD 512 GB: {Twelve}\r\nHDD/SSD 1000 GB: {One}\r\nHDD/SSD 2000 GB: {Two}";
        }
        //ПОИСК ПО ТАБЛИЦЕ
        private void textBoxSearch_SIA_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_SIA.Text.ToLower(); // Приведение введенного текста к нижнему регистру

            // Проверка, является ли строка поиска пустой
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Возвращение оригинального стиля для всех ячеек
                foreach (DataGridViewRow row in dataGridViewPC_SIA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = dataGridViewPC_SIA.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = dataGridViewPC_SIA.DefaultCellStyle.ForeColor;
                    }
                }
                return;
            }

            // Проход по каждой ячейке в dataGridViewPC_SIA
            foreach (DataGridViewRow row in dataGridViewPC_SIA.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Подсветка совпадающего слова
                        cell.Style.BackColor = Color.Silver;
                        cell.Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Возвращение оригинального стиля ячейки
                        cell.Style.BackColor = dataGridViewPC_SIA.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = dataGridViewPC_SIA.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }
        //ДОБАВЛЕНИЕ МЕТОДОВ ИЗ БИБЛИОТЕКИ К ЧЕКБОКСАМ
        //ЭВМ
        private void checkBoxAVM_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterAVM(dataGridViewPC_SIA, checkBoxAVM_SIA);
        }
        //ИЗГОТОВИТЕЛЬ
        private void checkBoxProd_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterProd(dataGridViewPC_SIA, checkBoxProd_SIA);
        }
        //ПРОЦЕССОР
        private void checkBoxCPU_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterCPU(dataGridViewPC_SIA, checkBoxCPU_SIA);
        }
        //ПАМЯТЬ ОЗУ
        private void checkBoxRAM_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterRAM(dataGridViewPC_SIA, checkBoxRAM_SIA);
        }
        //ТИП ЖЁСТКОГО ДИСКА
        private void checkBoxHaDr_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterHaDr(dataGridViewPC_SIA, checkBoxHaDr_SIA);
        }
        //ОБЪЁМ ЖЁСТКОГО ДИСКА
        private void checkBoxHaDrVo_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterHaDrVo(dataGridViewPC_SIA, checkBoxHaDrVo_SIA);
        }
        //ГОД ВЫПУСКА
        private void checkBoxYear_SIA_CheckedChanged(object sender, EventArgs e)
        {
            DataService.ApplyFilterYear(dataGridViewPC_SIA, checkBoxYear_SIA);
        }
        //ЗАПУСК ГРАФИКОВ
        private void buttonChart_SIA_Click(object sender, EventArgs e)
        {
            // Очищаем графики перед добавлением новых данных
            chartRAM_SIA.Series.Clear();
            chartHaDrVo_SIA.Series.Clear();

            // Создаем новые серии для графиков
            Series ramSeries = new Series();
            Series hddSeries = new Series();

            // Устанавливаем типы графиков
            ramSeries.ChartType = SeriesChartType.Point;
            hddSeries.ChartType = SeriesChartType.Point;

            // Привязываем серии к графикам
            chartRAM_SIA.Series.Add(ramSeries);
            chartHaDrVo_SIA.Series.Add(hddSeries);

            // Словари для хранения количества одинаковых значений
            Dictionary<string, int> ramValueCounts = new Dictionary<string, int>();
            Dictionary<string, int> hddValueCounts = new Dictionary<string, int>();

            // Перебираем значения столбцов из dataGridViewPC_SIA
            foreach (DataGridViewRow row in dataGridViewPC_SIA.Rows)
            {
                // Получаем значения столбцов "Объём ОЗУ" и "Объём жёсткого диска"
                string ramValue = row.Cells["Объём ОЗУ"].Value?.ToString() ?? "";
                string hddValue = row.Cells["Объём жёсткого диска"].Value?.ToString() ?? "";

                // Если значение не пустое, добавляем его в словарь и увеличиваем счетчик
                if (!string.IsNullOrEmpty(ramValue))
                {
                    if (ramValueCounts.ContainsKey(ramValue))
                    {
                        ramValueCounts[ramValue]++;
                    }
                    else
                    {
                        ramValueCounts[ramValue] = 1;
                    }
                }

                if (!string.IsNullOrEmpty(hddValue))
                {
                    if (hddValueCounts.ContainsKey(hddValue))
                    {
                        hddValueCounts[hddValue]++;
                    }
                    else
                    {
                        hddValueCounts[hddValue] = 1;
                    }
                }
            }

            // Добавляем значения в графики
            foreach (var kvp in ramValueCounts)
            {
                ramSeries.Points.AddXY(kvp.Key, kvp.Value);
            }

            foreach (var kvp in hddValueCounts)
            {
                hddSeries.Points.AddXY(kvp.Key, kvp.Value);
            }
        }
    }
}
