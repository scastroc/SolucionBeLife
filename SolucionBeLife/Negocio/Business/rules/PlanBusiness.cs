﻿using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules
{
    public interface PlanBusiness
    {
        void create(PlanEntity plan);

        void update(PlanEntity plan);

        void delete(PlanEntity plan);

        List<PlanEntity> listPlan();
    }
}
