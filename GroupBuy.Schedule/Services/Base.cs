using GroupBuy.Schedule.Models.Entites;
using GroupBuy.Schedule.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GroupBuy.Schedule.Services
{
    public class Base
    {
        
        public readonly GroupBuyEntities db;
        public Base() {
            db = EFService.CreateEntities();
        }
    }

}
