using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_Class03.ViewModels
{
    public class ProductCollection :ObservableCollection<ProductViewModel>
    {
        public void ClearList()
        {
            this.Items.Clear();
        }
    }
}
