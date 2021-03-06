﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface EstadoCivilDAO
    {
        List<EstadoCivilEntity> findAll();

        void create(EstadoCivilEntity estadoCivil);

        void delete(EstadoCivilEntity estadoCivil);

        void update(EstadoCivilEntity estadoCivil);
    }
}
