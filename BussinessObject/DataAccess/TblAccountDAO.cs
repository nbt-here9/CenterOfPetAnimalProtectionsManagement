﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataProvider;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BussinessObject.DataAccess
{
    public class TblAccountDAO
    {
        private static TblAccountDAO _instance;
        private DBEntities _db;
        private tblAccount acc = null;
        public static TblAccountDAO Instance
        {
            get { return _instance ?? (_instance = new TblAccountDAO()); }
        }

        public TblAccountDAO()
        {
            _db = DBProvider.Instance.Db;

        }

        public tblAccount Acc => acc;

        #region Thu

        //NBT -  This function will check login
        public tblAccount CheckLogin(string username, string password)
        {
            var user = (from u in _db.tblAccount
                        where u.username == username && u.password == password
                        select u).SingleOrDefault();
            return user;
        }

        //NBT -  This function will get all accounts have role adopter
        public List<tblAccount> GetAllAdopters()
        {
            var listAdopters = (from a in _db.tblAccount
                                where a.roleID == 2 && a.status == true 
                                      && a.isInBlackList == false
                                select a).ToList();
            return listAdopters;
        }

        public tblAccount GetAccountByUsername(string username)
        {
            return _db.tblAccount.Find(username);
        }

        public bool UpdateAdopter(tblAccount adopter)
        {
            Console.WriteLine(adopter.username);
            Console.WriteLine(adopter.password);
            Console.WriteLine(adopter.fullname);
            Console.WriteLine(adopter.address);
            var update = (from a in _db.tblAccount
                          where a.username == adopter.username
                          select a)
                .SingleOrDefault();
            if (update != null)
            {
                update.username = adopter.username;
                update.password = adopter.password;
                update.fullname = adopter.fullname;
                update.address = adopter.address;
                update.phone = adopter.phone;
                update.isInBlackList = adopter.isInBlackList;
                update.reasonBlackList = adopter.reasonBlackList;
                update.roleID = adopter.roleID;
                update.status = adopter.status;
                update.image = adopter.image;
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteAdopter(string username)
        {
            tblAccount adopter = _db.tblAccount.Find(username);
            if (username != null)
            {
                adopter.status = false;
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<tblAccount> SearchAdopters(string username, string fullname, string phone, bool isInBlacklist, bool status)
        {
            var result = (from a in _db.tblAccount
                          where DbFunctions.Like(a.username.ToString(), $"%" + username + "%")

                                && DbFunctions.Like(a.fullname.ToString(), $"%" + fullname + "%")

                                && DbFunctions.Like(a.phone.ToString(), $"%" + phone + "%")

                                && DbFunctions.Like(a.isInBlackList.ToString(), $"%" + isInBlacklist + "%")

                                && DbFunctions.Like(a.status.ToString(), $"%" + status + "%")

                          select a).ToList();
            return result;
        }

        #endregion

        #region Lam

        public bool CreateAdopter(tblAccount adopter)
        {
            try {
                adopter.tblRole = TblRoleDAO.Instance.GetRoleById(adopter.roleID);
                tblAccount result = DBProvider.Instance.Db.tblAccount.Add(adopter);
                if (result != null) DBProvider.Instance.Db.SaveChanges();
                return result != null;
             } catch (DbUpdateException) {
                DBProvider.Instance.Db.tblAccount.Remove(adopter);
                throw;
            }
}

        #endregion
    }
}
