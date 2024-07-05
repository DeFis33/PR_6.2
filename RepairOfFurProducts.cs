using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2
{
    public partial class RepairOfFurProducts : Form
    {
        public RepairOfFurProducts()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            comboBoxRepairType.Items.AddRange(new string[]
            {
                "Замена молнии", "Ремонт шва", "Замена пуговиц", "Починка кармана"
            });
            comboBoxProductType.Items.AddRange(new string[]
            {
                "Шуба", "Жилет", "Пальто"
            });
            comboBoxTypeOfFur.Items.AddRange(new string[]
            {
                "Норка", "Лиса", "Кролик", "Песец"
            });
        }
        private void btnBackRepairOfFurProducts_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            this.Close();
        }
        private void btnStartTheRepair_Click(object sender, EventArgs e)
        {
            if (comboBoxRepairType.SelectedIndex == -1 ||
                comboBoxProductType.SelectedIndex == -1 ||
                comboBoxTypeOfFur.SelectedIndex == -1)
            {
                MessageBox.Show("Нужно выбрать все параметры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Ремонт мехового изделия прошёл успешно.", "Ремонт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtelierWork atelierWork = new AtelierWork();
                atelierWork.Show();
                this.Close();
            }
        }
    }
}
