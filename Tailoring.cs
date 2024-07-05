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
    public partial class Tailoring : Form
    {
        public Tailoring()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            comboBoxChestCircumference.Items.AddRange(new string[]
            {
                "85 см", "90 см", "95 см", "100 см", "105 см"
            });
            comboBoxWaistCircumference.Items.AddRange(new string[]
            {
                "65 см", "70 см", "75 см", "80 см", "85 см", "90 см"
            });
            comboBoxSleeveLength.Items.AddRange(new string[]
            {
                "55 см", "60 см", "65 см"
            });
            comboBoxShoulderWidth.Items.AddRange(new string[]
            {
                "36 см", "38 см", "40 см", "42 см", "44 см", "46 см"
            });
            comboBoxFabricSelection.Items.AddRange(new string[]
            {
                "Хлопок", "Шерсть", "Лён"
            });
            comboBoxСhoosingСlothes.Items.AddRange(new string[]
            {
                "Рубашка", "Блузка", "Платье", "Костюм", "Пиджак", "Пальто", "Куртка"
            });
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxChestCircumference.SelectedIndex == -1 ||
                    comboBoxWaistCircumference.SelectedIndex == -1 ||
                    comboBoxSleeveLength.SelectedIndex == -1 ||
                    comboBoxShoulderWidth.SelectedIndex == -1 ||
                    comboBoxFabricSelection.SelectedIndex == -1 ||
                    comboBoxСhoosingСlothes.SelectedIndex == -1)
            {
                MessageBox.Show("Нужно выбрать все параметры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Шитьё прошло успешно.", "Шитьё", MessageBoxButtons.OK, MessageBoxIcon.Question);
                AtelierWork atelierWork = new AtelierWork();
                atelierWork.Show();
                this.Close();
            }
        }
    }
}