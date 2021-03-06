﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface SexoDAO
    {
        List<SexoEntity> findAll();

        void create(SexoEntity sexo);

        void delete(SexoEntity sexo);

        void update(SexoEntity sexo);
    }
}
