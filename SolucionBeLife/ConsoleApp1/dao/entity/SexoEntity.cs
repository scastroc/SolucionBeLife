﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class SexoEntity
    {
        private int id;
        private string descripcion;

        public SexoEntity()
        {

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
