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
    public partial class SewingCurtains : Form
    {
        public SewingCurtains()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            comboBoxCurtainWidth.Items.AddRange(new string[] 
            {
                "1 м", "1.5 м", "2 м", "2.5 м", "3 м", "3.5 м", "4 м", "4.5 м", "5 м"
            });
            comboBoxCurtainHeight.Items.AddRange(new string[]
            {
                "1 м", "1.5 м", "2 м", "2.5 м", "3 м", "3.5 м", "4 м", "4.5 м", "5 м"
            });
            comboBoxFabricType.Items.AddRange(new string[]
            {
                "Хлопок", "Лён", "Шёлк"
            });
            comboBoxTypeOfCurtains.Items.AddRange(new string[]
            {
                "Римские", "Рулонные", "Классические"
            });
        }
        private void btnBackSewingCurtains_Click(object sender, EventArgs e)
        {
            AtelierWork atelierWork = new AtelierWork();
            atelierWork.Show();
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxCurtainWidth.SelectedIndex == -1 ||
                    comboBoxCurtainHeight.SelectedIndex == -1 ||
                    comboBoxFabricType.SelectedIndex == -1 ||
                    comboBoxTypeOfCurtains.SelectedIndex == -1)
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
