﻿using Com.Efrata.Service.Purchasing.Lib.Helpers.ReadResponse;
using Com.Efrata.Service.Purchasing.Lib.Models.GarmentUnitDeliveryOrderModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Purchasing.Lib.Interfaces
{
    public interface IGarmentUnitDeliveryOrderFacade
    {
        ReadResponse<object> Read(int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}");
        GarmentUnitDeliveryOrder ReadById(int id);
        Task<int> Create(GarmentUnitDeliveryOrder garmentUnitDeliveryOrder);
        Task<int> Update(int id, GarmentUnitDeliveryOrder garmentUnitDeliveryOrder);
        Task<int> Delete(int id);
        ReadResponse<object> ReadForUnitExpenditureNote(int Page = 1, int Size = 10, string Order = "{}", string Keyword = null, string Filter = "{}");
        List<object> ReadForLeftOver(string ro);

        GarmentUnitDeliveryOrderItem ReadItemById(int id);
    }
}
