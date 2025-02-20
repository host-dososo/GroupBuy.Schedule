using GroupBuy.Schedule.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace GroupBuy.Schedule.Services
{
    public static class EFService
    {
        
        public static GroupBuyEntities _db;

        public static void SetEntities(GroupBuyEntities db) {
            _db = db;
        }

        public static GroupBuyEntities CreateEntities() {
            return _db;
        }
    }
}
