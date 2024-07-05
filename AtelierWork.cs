using System;
using System.Windows.Forms;

namespace PR6._2
{
    public partial class AtelierWork : Form
    {
        private readonly IFacade facade;
        public AtelierWork()
        {
            InitializeComponent();
            facade = new AtelierFacade();
        }
        private void btnExitFromTheStudio_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExitFromTheStudio_Click(sender, e);
        }
        private void btnTailoring_Click(object sender, EventArgs e)
        {
            facade.OpenTailoringForm();
            this.Close();
        }
        private void btnUrgentClothingRepair_Click(object sender, EventArgs e)
        {
            facade.OpenUrgentClothingRepairForm();
            this.Close();
        }
        private void btnLeatherRepair_Click(object sender, EventArgs e)
        {
            facade.OpenLeatherRepairForm();
            this.Close();
        }
        private void btnRepairOfFurProducts_Click(object sender, EventArgs e)
        {
            facade.OpenRepairOfFurProductsForm();
            this.Close();
        }
        private void btnSewingCurtains_Click(object sender, EventArgs e)
        {
            facade.OpenSewingCurtainsForm();
            this.Close();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facade.ShowInfo();
        }
        private void tailoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTailoring_Click(sender, e);
        }
        private void urgentClothingRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUrgentClothingRepair_Click(sender, e);
        }
        private void leatherRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLeatherRepair_Click(sender, e);
        }
        private void repairOfFurProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRepairOfFurProducts_Click(sender, e);
        }
        private void sewingCurtainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSewingCurtains_Click(sender, e);
        }
    }
}
