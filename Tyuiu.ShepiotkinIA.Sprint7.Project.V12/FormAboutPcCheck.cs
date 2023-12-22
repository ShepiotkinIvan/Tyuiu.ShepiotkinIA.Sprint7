using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    public partial class FormAboutPcCheck : Form
    {
        public FormAboutPcCheck()
        {
            InitializeComponent();
        }

        private void FormAboutPcCheck_Load(object sender, EventArgs e)
        {
            DisplayHardwareInfo();
        }

        private void DisplayHardwareInfo()
        {
            // Создание столбцов таблицы
            dataGridViewPcCheck_SIA.ColumnCount = 2;
            dataGridViewPcCheck_SIA.Columns[0].Name = "Компонент";
            dataGridViewPcCheck_SIA.Columns[1].Name = "Значение";

            // Получение информации о железе ПК
            string motherboard = GetHardwareInfo("Win32_BaseBoard", "Product");
            string videocard = GetHardwareInfo("Win32_VideoController", "Name");
            string processor = GetHardwareInfo("Win32_Processor", "Name");
            string hardDisk = GetHardwareInfo("Win32_DiskDrive", "Model");
            string memory = GetHardwareInfo("Win32_OperatingSystem", "TotalVisibleMemorySize");

            // Заполнение таблицы
            string[] row1 = { "Материнская плата", motherboard };
            string[] row2 = { "Видеокарта", videocard };
            string[] row3 = { "Процессор", processor };
            string[] row4 = { "Жесткий диск", hardDisk };
            string[] row5 = { "Оперативная память", memory };
            dataGridViewPcCheck_SIA.Rows.Add(row1);
            dataGridViewPcCheck_SIA.Rows.Add(row2);
            dataGridViewPcCheck_SIA.Rows.Add(row3);
            dataGridViewPcCheck_SIA.Rows.Add(row4);
            dataGridViewPcCheck_SIA.Rows.Add(row5);
            dataGridViewPcCheck_SIA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPcCheck_SIA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }
        private string GetHardwareInfo(string wmiClass, string property)
        {
            // Получение информации о железе ПК с помощью класса ManagementObjectSearcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + wmiClass);
            foreach (ManagementObject managementObject in searcher.Get())
            {
                if (managementObject.Properties[property] != null)
                {
                    return managementObject.Properties[property].Value.ToString();
                }
            }

            return "Неизвестно";
        }
    }
}
