using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6._2
{
    interface IFacade
    {
        void OpenTailoringForm();
        void OpenUrgentClothingRepairForm();
        void OpenLeatherRepairForm();
        void OpenRepairOfFurProductsForm();
        void OpenSewingCurtainsForm();
        void ShowInfo();
    }
    class AtelierFacade : IFacade
    {
        public void OpenTailoringForm()
        {
            Tailoring tailoring = new Tailoring();
            tailoring.Show();
        }
        public void OpenUrgentClothingRepairForm()
        {
            UrgentClothingRepair urgentClothingRepair = new UrgentClothingRepair();
            urgentClothingRepair.Show();
        }
        public void OpenLeatherRepairForm()
        {
            LeatherRepair leatherRepair = new LeatherRepair();
            leatherRepair.Show();
        }
        public void OpenRepairOfFurProductsForm()
        {
            RepairOfFurProducts repairOfFurProducts = new RepairOfFurProducts();
            repairOfFurProducts.Show();
        }
        public void OpenSewingCurtainsForm()
        {
            SewingCurtains sewingCurtains = new SewingCurtains();
            sewingCurtains.Show();
        }
        public void ShowInfo()
        {
            Info info = new Info();
            info.Show();
        }
    }
}