﻿using System;
using System.Data.SqlClient;
using ZkManagement.Entidades;
using log4net;
using System.Collections.Generic;

namespace ZkManagement.Datos
{
    class CatalogoHuellas
    {
        private Conexion con = new Conexion();
        private SqlConnection conn = new SqlConnection();
        private ILog logger = LogManager.GetLogger("");

        public void InsertarHuella(Huella h, int id)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Huellas (IdEmpleado, Template, FingerIndex, Lengh, Flag) VALUES(" + id.ToString() + ", '" + h.Template + "', '" + h.FingerIndex.ToString() + "', '" + h.Lengh.ToString() + "', '" + h.Flag.ToString() + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                logger.Error(sqlEx.StackTrace);
                throw (sqlEx);
              //  throw new Exception("Error al insertar registros en la tabla huellas");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar actualizar en la tabla huellas");
            }
            conn.Close();
        }

        public bool Existe(Huella h, int id)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT HuellaId FROM HUELLAS WHERE IdEmpleado='"+id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'" , conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;                  
                }
            }
            catch (SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla de huellas");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al consultar la tabla huellas");
            }            
        }

        public void ActualizarHuella(Huella h, int id)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE Huellas SET Template='" + h.Template + "', Lengh='" + h.Lengh + "', Flag='" + h.Flag.ToString() + 
                    "' WHERE IdEmpleado='" + id.ToString() + "' AND FingerIndex='" + h.FingerIndex.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al actualizar la tabla de huellas");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al actualizar la tabla huellas");
            }
        }
        public List<Huella> GetHuellas(int id)
        {
            List<Huella> huellas = new List<Huella>();
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Huellas WHERE IdEmpleado=" + id.ToString(),conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Huella h = new Huella();
                    h.FingerIndex = Convert.ToInt32(dr["FingerIndex"]);
                    h.Lengh = Convert.ToInt32(dr["Lengh"]);
                    h.Template = dr["Template"].ToString();
                    h.Flag = Convert.ToInt32(dr["Flag"]);
                    huellas.Add(h);
                }
            }
            catch(SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al consultar la tabla huellas");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error desconocido al intentar consultar la tabla huellas");
            }
            conn.Close();
            return huellas;
        }

        public void EliminarHuella(int id)
        {
            try
            {
                conn = con.Conectar();
                SqlCommand cmd = new SqlCommand("DELETE FROM Huellas WHERE IdEmpleado=" + id.ToString(), conn);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException sqlex)
            {
                logger.Error(sqlex.StackTrace);
                throw new Exception("Error al intentar eliminar las huellas");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex.StackTrace);
                throw new Exception("Error no controlado al intentar eliminar las huellas");
            }
            conn.Close();
        }
    }
}
