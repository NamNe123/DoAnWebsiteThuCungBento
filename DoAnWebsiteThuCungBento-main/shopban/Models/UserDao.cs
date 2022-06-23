using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopban.Models
{
    public class UserDao
    {
        ShopDataDataContext db = null;
        public UserDao()
        {
            db = new ShopDataDataContext();
        }

        public long InsertForFacebook(KHACHHANG entity)
        {
            var user = db.KHACHHANGs.SingleOrDefault(x => x.HoTen == entity.HoTen);
            if (user == null)
            {
                db.KHACHHANGs.InsertOnSubmit(entity);
                db.SubmitChanges();
                return entity.MaKH;
            }
            return user.MaKH;
        }

    }
}