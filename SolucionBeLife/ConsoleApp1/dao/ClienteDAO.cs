﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface ClienteDAO
    {
        List<ClienteEntity> findAll();

        void create(ClienteEntity cliente);

        void delete(ClienteEntity cliente);

        void update(ClienteEntity cliente);
    }
}
