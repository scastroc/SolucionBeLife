﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface ContratoDAO
    {
        List<ContratoEntity> findAll();

        void create(ContratoEntity contrato);

        void delete(ContratoEntity contrato);

        void update(ContratoEntity contrato);
    }
}
