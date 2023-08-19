﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticoNro1
{
    public abstract class Transport
    {
        private int _numeroPasajeros;
        public Transport(int NumeroPasajeros)
        {
            _numeroPasajeros = NumeroPasajeros;
        }
        public int NumeroPasajeros
        {
            get
            {
                return _numeroPasajeros;
            }
            set
            {

                _numeroPasajeros = value;
            }
        }

        public abstract string Report();
        public string Avanzar()
        {
            return " ";
        }

        public string Detenerse()
        {
            return " ";
        }
        
    }


}