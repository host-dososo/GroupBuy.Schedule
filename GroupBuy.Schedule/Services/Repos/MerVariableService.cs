using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.DataClassification;

namespace GroupBuy.Schedule.Services.Repos
{
    public class MerVariableService : Base
    {
        public MerVariableService()
        {
        }
      

        public ServiceResult<v_MerVariable> GetOne(int merchantId,int keyId)
        {
            var sr = new ServiceResult<v_MerVariable>();
            try
            {
                var merVar = db.v_MerVariable.FirstOrDefault(v => v.MerchantId == merchantId && v.KeyId == keyId);
                sr.SetResult(merVar);
            }
            catch (Exception ex)
            {
                sr.SetResult(ex);
            }
            return sr;
        }
    }
}
