﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ITinTucDAL
    {
        TinTuc GetId(int id);
        List<TinTuc> getalldata();
        void Create(TinTuc sp);
        void Delete(int id);
        void Edit(TinTuc sp);
    }
}
