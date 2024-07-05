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
    public partial class UrgentClothingRepair : Form
    {
        public UrgentClothingRepair()
        {
            InitializeComponent();
            FillRepairTypes();
        }
        private void FillRepairTypes()
        {
            comboBoxRepairType.Items.AddRange(new string[]
            {
                "Замена молнии", "Ремонт шва", "Замена пуговиц", "Починка кармана"
            });
            comboBoxUrgency.Items.AddRange(new string[]
            {
                "Немедленно", "В течение дня"
            });
            comboBoxTypeOfClothing.Items.AddRange(new string[]
            {
                "Рубашка", "Брюки", "Куртка"
            });
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            this.Close();
        }
        private void btnBackUrgentClothingRepair_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            this.Close();
        }
        private void btnStartTheRepair_Click(object sender, EventArgs e)
        {
            if (comboBoxRepairType.SelectedIndex == -1 ||
                    comboBoxUrgency.SelectedIndex == -1 ||
                    comboBoxTypeOfClothing.SelectedIndex == -1)
            {
                MessageBox.Show("Нужно выбрать все параметры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string message = comboBoxUrgency.SelectedItem.ToString() == "Немедленно" ?
                    "Шитьё начато незамедлительно." :
                    "Шитьё будет начато в течение дня.";
                MessageBox.Show(message, "Шитьё", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtelierWork atelierWork = new AtelierWork();
                atelierWork.Show();
                this.Close();
            }
        }
    }
}
