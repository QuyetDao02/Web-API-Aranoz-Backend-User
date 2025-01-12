﻿using DAL.Interface;
using BLL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBusiness : INhaCungCapBussiness
    {
        public INhaCungCapDAL db;
        public NhaCungCapBusiness(INhaCungCapDAL db)
        {
            this.db = db;
        }
        public List<NhaCungCap> GetAll()
        {
            return db.GetAll();
        }
        public NhaCungCap GetSupId(int id)
        {
            return db.GetSupId(id);
        }
        public void Create(NhaCungCap ncc)
        {
            db.Create(ncc);
        }
        public void Delete(int id)
        {
            db.Delete(id);
        }
        public void Update(NhaCungCap ncc)
        {
            db.Update(ncc);
        }
        public List<NhaCungCap> Search(int page, int pagesize, string nd)
        {
            return db.Search(page, pagesize, nd);
        }
    }
}
