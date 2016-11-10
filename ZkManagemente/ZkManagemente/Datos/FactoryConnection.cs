﻿using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using ZkManagement.Util;

namespace ZkManagement.Datos
{
    class FactoryConnection
    {
        private static int cantConn;
        private static FactoryConnection _instancia;

        public static FactoryConnection GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FactoryConnection();
            }
            return _instancia;
        }

        private static IDbConnection cnn;

        public enum DBType
        {
            SQL,
            Access,
            Saftime
        }
        public IDbConnection GetConnection()
        {
            DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
            try
            {
                switch (dbtype)
                {
                    case DBType.Access:
                        cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                    case DBType.SQL:
                        cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                    case DBType.Saftime:
                        cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SaftimeDB"].ConnectionString);
                        cnn.Open();
                        break;
                    default:
                        cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNS"].ConnectionString);
                        cnn.Open();
                        break;
                }
                cantConn++;
            }
            catch (DbException dbex)
            {
                Logger.GetLogger().Error(dbex.StackTrace);
                throw new Exception("Error al intentar la conexión a la base de datos");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar la conexión a la base de datos");
            }
            return cnn;
        }

        public IDbCommand Update(string command, IDbConnection cnn) //La conexión ya me llega abierta.
        {
            IDbCommand cmd;
            try
            {
                DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
                switch (dbtype)
                {
                    case DBType.Access:
                        cmd = new OleDbCommand(command, (OleDbConnection)cnn);
                        break;

                    case DBType.SQL:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        break;

                    case DBType.Saftime:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        break;
                    default:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        break;
                }
            }
            catch (DbException dbex)
            {
                Logger.GetLogger().Error(dbex.StackTrace);
                throw new Exception("Error al intentar crear la consulta");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado durante la creación de la consulta");
            }

            return cmd;
        }

        public DbDataReader Consult(string command, IDbConnection cnn) //La conexión ya me llega abierta.
        {
            IDbCommand cmd;
            DbDataReader dr;
            try
            {
                DBType dbtype = (DBType)Enum.Parse(typeof(DBType), ConfigurationManager.AppSettings["DatabaseType"]);
                switch (dbtype)
                {
                    case DBType.Access:
                        cmd = new OleDbCommand(command, (OleDbConnection)cnn);
                        dr = (OleDbDataReader)cmd.ExecuteReader();
                        break;

                    case DBType.SQL:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        dr = (SqlDataReader)cmd.ExecuteReader();
                        break;

                    case DBType.Saftime:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        dr = (SqlDataReader)cmd.ExecuteReader();
                        break;
                    default:
                        cmd = new SqlCommand(command, (SqlConnection)cnn);
                        dr = (SqlDataReader)cmd.ExecuteReader();
                        break;
                }
            }
            catch (DbException dbex)
            {
                Logger.GetLogger().Error(dbex.StackTrace);
                throw new Exception("Error al intentar crear la consulta");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado durante la creación de la consulta");
            }

            return dr;
        }

        public void ReleaseConn()
        {
            try
            {
                cantConn--;
                if (cantConn == 0)
                {
                    cnn.Close();
                }
            }
            catch (DbException dbex)
            {
                Logger.GetLogger().Error(dbex.StackTrace);
                throw new Exception("Error al intentar cerrar la conexión a la base de datos");
            }
            catch (Exception ex)
            {
                Logger.GetLogger().Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar cerrar la conexión a la base de datos");
            }

        }

    }
}