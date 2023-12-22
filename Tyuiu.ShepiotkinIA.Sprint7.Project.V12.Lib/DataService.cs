using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        //МЕТОДЫ ДЛЯ ЧЕКБОКСОВ
        //ЭВМ
        public static void ApplyFilterAVM(DataGridView dataGridViewPC_SIA, CheckBox checkBoxAVM_SIA)
        {
            if (checkBoxAVM_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["ЭВМ"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["ЭВМ"].Visible = true;
            }
        }
        //ИЗГОТОВИТЕЛЬ
        public static void ApplyFilterProd(DataGridView dataGridViewPC_SIA, CheckBox checkBoxProd_SIA)
        {

            if (checkBoxProd_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Изготовитель"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Изготовитель"].Visible = true;
            }
        }
        //ПРОЦЕССОР
        public static void ApplyFilterCPU(DataGridView dataGridViewPC_SIA, CheckBox checkBoxCPU_SIA)
        {
            if (checkBoxCPU_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Процессор"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Процессор"].Visible = true;
            }
        }
        //ПАМЯТЬ ОЗУ
        public static void ApplyFilterRAM(DataGridView dataGridViewPC_SIA, CheckBox checkBoxRAM_SIA)
        {
            if (checkBoxRAM_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Объём ОЗУ"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Объём ОЗУ"].Visible = true;
            }
        }
        //ТИП ЖЁСТКОГО ДИСКА
        public static void ApplyFilterHaDr(DataGridView dataGridViewPC_SIA, CheckBox checkBoxHaDr_SIA)
        {
            if (checkBoxHaDr_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Тип жёсткого диска"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Тип жёсткого диска"].Visible = true;
            }
        }
        //ОБЪЁМ ЖЁСТКОГО ДИСКА
        public static void ApplyFilterHaDrVo(DataGridView dataGridViewPC_SIA, CheckBox checkBoxHaDrVo_SIA)
        {
            if (checkBoxHaDrVo_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Объём жёсткого диска"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Объём жёсткого диска"].Visible = true;
            }
        }
        //ГОД ВЫПУСКА
        public static void ApplyFilterYear(DataGridView dataGridViewPC_SIA, CheckBox checkBoxYear_SIA)
        {
            if (checkBoxYear_SIA.Checked)
            {
                dataGridViewPC_SIA.Columns["Год выпуска ЭВМ"].Visible = false;
            }
            else
            {
                dataGridViewPC_SIA.Columns["Год выпуска ЭВМ"].Visible = true;
            }
        }
    }
}
