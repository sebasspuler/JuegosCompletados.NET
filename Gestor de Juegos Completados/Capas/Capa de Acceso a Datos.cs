﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gestor_de_Juegos_Completados
{
    public class Capa_de_Acceso_a_Datos
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Gestor Juegos Completados;Data Source=DESKTOP-IIGG7JF");

        #region Consultas Directas
        /*
        public void InsertarJuego(Juego juego)
        {
            try
            {
                conn.Open();
                string query = @" INSERT INTO JUEGOS(Nombre, Completado, Cienporciento, Logros, Cantidad, Nota, Fecha)
                                  VALUES (@Nombre, @Completado, @Cienporciento, @Logros, @Cantidad, @Nota, @Fecha)";

                SqlParameter Nombre = new SqlParameter("@Nombre", juego.Nombre);
                SqlParameter Completado = new SqlParameter("@Completado", juego.Completado);
                SqlParameter Cienporciento = new SqlParameter("@Cienporciento", juego.Cienporciento);
                SqlParameter Logros = new SqlParameter("@Logros", juego.Logros);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", juego.cantidadVeces);
                SqlParameter Nota = new SqlParameter("@Nota", juego.Nota);
                SqlParameter Fecha = new SqlParameter("@Fecha", juego.Fecha);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Completado);
                command.Parameters.Add(Cienporciento);
                command.Parameters.Add(Logros);
                command.Parameters.Add(Cantidad);
                command.Parameters.Add(Nota);
                command.Parameters.Add(Fecha);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void ActualizarJuego(Juego juego)
        {
            try
            {
                conn.Open();
                string query = @" UPDATE Juegos
                                  SET Nombre = @Nombre,
                                      Completado = @Completado,
                                      Cienporciento = @Cienporciento,
                                      Logros = @Logros,
                                      Cantidad = @Cantidad,
                                      Nota = @Nota,
                                      Fecha = @Fecha
                                      Where Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", juego.Id);
                SqlParameter Nombre = new SqlParameter("@Nombre", juego.Nombre);
                SqlParameter Completado = new SqlParameter("@Completado", juego.Completado);
                SqlParameter Cienporciento = new SqlParameter("@Cienporciento", juego.Cienporciento);
                SqlParameter Logros = new SqlParameter("@Logros", juego.Logros);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", juego.cantidadVeces);
                SqlParameter Nota = new SqlParameter("@Nota", juego.Nota);
                SqlParameter Fecha = new SqlParameter("@Fecha", juego.Fecha);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Completado);
                command.Parameters.Add(Cienporciento);
                command.Parameters.Add(Logros);
                command.Parameters.Add(Cantidad);
                command.Parameters.Add(Nota);
                command.Parameters.Add(Fecha);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void BorrarJuego(int id)
        {
            try
            {
                conn.Open();
                string query = @"DELETE from Juegos where Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", id);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public List<Juego> GetJuegos(string buscar = null)
        {
            List<Juego> juegos = new List<Juego>();

            try
            {
                conn.Open();
                string query = @"SELECT Id, Nombre, Completado, Cienporciento, Logros,
                                        Cantidad, Nota, Fecha FROM Juegos";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE Nombre LIKE @Search OR Completado LIKE @Search OR 
                                  Cienporciento LIKE @Search OR Logros LIKE @Search OR 
                                  Cantidad LIKE @Search OR Nota LIKE @Search
                                  OR Fecha LIKE @Search ";

                    command.Parameters.Add(new SqlParameter("@Search", $"%{buscar}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    juegos.Add(new Juego
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Completado = reader["Completado"].ToString(),
                        Cienporciento = reader["Cienporciento"].ToString(),
                        Logros = reader["Logros"].ToString(),
                        cantidadVeces = int.Parse(reader["Cantidad"].ToString()),
                        Nota = int.Parse(reader["Nota"].ToString()),
                        Fecha = DateTime.Parse(reader["Fecha"].ToString())

                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            return juegos;
        }
        */
        #endregion

        #region Stored Procedures
        public void InsertarJuego(Juego juego)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("spInsertarJuego", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", juego.Nombre);
                command.Parameters.AddWithValue("@Completado", juego.Completado);
                command.Parameters.AddWithValue("@Cienporciento", juego.Cienporciento);
                command.Parameters.AddWithValue("@Logros", juego.Logros);
                command.Parameters.AddWithValue("@Cantidad", juego.cantidadVeces);
                command.Parameters.AddWithValue("@Nota", juego.Nota);
                command.Parameters.AddWithValue("@Fecha", juego.Fecha);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void ActualizarJuego(Juego juego)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("spActualizarJuego", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", juego.Id);
                command.Parameters.AddWithValue("@Nombre", juego.Nombre);
                command.Parameters.AddWithValue("@Completado", juego.Completado);
                command.Parameters.AddWithValue("@Cienporciento", juego.Cienporciento);
                command.Parameters.AddWithValue("@Logros", juego.Logros);
                command.Parameters.AddWithValue("@Cantidad", juego.cantidadVeces);
                command.Parameters.AddWithValue("@Nota", juego.Nota);
                command.Parameters.AddWithValue("@Fecha", juego.Fecha);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void BorrarJuego(int id)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("spBorrarJuego", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Juego> GetJuegos(string buscar = null)
        {
            List<Juego> juegos = new List<Juego>();

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("spGetJuegos", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (!string.IsNullOrEmpty(buscar))
                {
                    command.Parameters.AddWithValue("@Buscar", buscar);
                }
                else
                {
                    command.Parameters.AddWithValue("@Buscar", DBNull.Value);
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    juegos.Add(new Juego
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Completado = reader["Completado"].ToString(),
                        Cienporciento = reader["Cienporciento"].ToString(),
                        Logros = reader["Logros"].ToString(),
                        cantidadVeces = int.Parse(reader["Cantidad"].ToString()),
                        Nota = int.Parse(reader["Nota"].ToString()),
                        Fecha = DateTime.Parse(reader["Fecha"].ToString())
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return juegos;
        }
        #endregion
    }
}
