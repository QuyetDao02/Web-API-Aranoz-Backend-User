﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL.Interface
{
    public interface IDonHangBusiness
    {
        void AddCart(DonHangBan dh);
    }
}
