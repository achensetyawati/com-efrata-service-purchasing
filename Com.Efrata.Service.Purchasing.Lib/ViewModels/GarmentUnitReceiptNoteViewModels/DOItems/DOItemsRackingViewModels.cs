using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Purchasing.Lib.ViewModels.GarmentUnitReceiptNoteViewModels.DOItems
{
    public class DOItemsRackingViewModels
    {
        public string POSerialNumber { get; set; }
        public List<RackingViewModels> Items { get; set; }
    }
}
