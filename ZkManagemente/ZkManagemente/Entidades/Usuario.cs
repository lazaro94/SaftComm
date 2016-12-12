﻿
using System;
using ZkManagement.Util;

namespace ZkManagement.Entidades
{
    public class Usuario
    {
        private string _usr;
        private string _pass;
        private int _nivel;
        private int _id;
        private string _permisos;
        private DateTime? _ultimoAcceso;

        //CONSTRUCTORES
        public Usuario(string usr, string pass,int nivel, int id)
        {           
            Usr = usr;
            PassDecrypt = pass;
            Nivel = nivel;
            Id = id;
        }

        public Usuario()
        {
        }

        //PROPIEDADES

        public DateTime? UltimoAcceso
        {
            get { return _ultimoAcceso; }
            set { _ultimoAcceso = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public string PassDecrypt
        {
            get
            {
                return Encrypt.DesEncriptar(_pass);
            }
            set
            {
                _pass = value;
            }
        }
        public string PassEncrypt
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = Encrypt.Encriptar(value);
            }
        }


        public string Usr
        {
            get { return _usr; }
            set { _usr = value; }
        }

        public string Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }

        internal string ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
