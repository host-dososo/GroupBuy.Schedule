using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient.DataClassification;
using Newtonsoft.Json;

namespace GroupBuy.Schedule.Services.Repos
{
    public class MerSchedJobService : Base
    {
        public MerSchedJobService()
        {
        }


        public ServiceResult<MerSchedJob> GetOne(string jobId)
        {
            var sr = new ServiceResult<MerSchedJob>();
            try
            {
                var msj = db.MerSchedJob.FirstOrDefault(j => j.JobId.ToString() == jobId);
                sr.SetResult(msj);
            }
            catch (Exception ex)
            {
                sr.SetResult(ex);
            }
            return sr;
        }

        public ServiceResult<MerSchedJob> UpdateResult(string jobId, ServiceResult<object> result) {
            var sr = new ServiceResult<MerSchedJob>();
            try {
                var msj = db.MerSchedJob.FirstOrDefault(j => j.JobId.ToString() == jobId);
                if (msj != null)
                {
                    msj.Result = JsonConvert.SerializeObject(result);
                    db.SaveChanges();
                    sr.SetResult(msj);
                }
                

            }
            catch (Exception ex) {
                sr.SetResult(ex);
            }
            return sr;
        }
    }
}
