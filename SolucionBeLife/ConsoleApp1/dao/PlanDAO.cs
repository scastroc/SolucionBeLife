﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao
{
    public interface PlanDAO
    {
        List<PlanEntity> findAll();

        void create(PlanEntity plan);

        void delete(PlanEntity plan);

        void update(PlanEntity plan);
    }
}
