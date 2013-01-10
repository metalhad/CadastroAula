﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro.DAL;
using Cadastro.DAL.EntityFrameworkProvider;
using Cadastro.DAL.SqlProvider;
using Cadastro.Model;

namespace Cadastro.Factory
{
    public static class DaoFactory
    {
        public static IDAL<Fisica> GetFisicaDao()
        {
            //return new FisicaDao();
            return Persistencia.GetInstance().FisicaDao;
        }
    }
}