// Works Only On Dotnet Framework ,ADO.NET Stack

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Web;

namespace HotelWCFService
{
      public class Items
      {
            public int ItemId { get; set; }
            public string ItemName { get; set; }
            public int Price { get; set; }

      }

      public class Caller
      {
            public List<Items> GetItems()
            {
                  using (SqlCommand cmd = new SqlCommand())
                  {
                        cmd.CommandText = "Select * from Items;";
                        return GenCon<Items>.ExecutorGen(cmd); // Return List By Executing a Query
                  }
            }
      }
      public static class GenCon<T> where T : new()
      {
            const string con = "Data Source=VINOTH\\SQLEXPRESS;Initial Catalog = HotelManagement; Integrated Security = True";
            public static List<T> ExecutorGen(SqlCommand cmd)
            {
                  List<T> list = new List<T>();
                  try
                  {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                              cmd.Connection = connection;
                              connection.Open();

                              using (SqlDataReader rdr = cmd.ExecuteReader())
                              {
                                    while (rdr.Read())
                                    {
                                          // Method 1
                                          //Type Type = typeof(T);
                                          //var extendedObject = Activator.CreateInstance(Type);

                                          // Method 2
                                          Type Type = typeof(T);
                                          T t = new T();
                                          PropertyInfo[] properties = t.GetType().GetProperties();
                                          foreach (var p in properties)
                                          {
                                                Type.GetProperty(p.Name)
                                                      .SetValue(t, rdr[p.Name], null);
                                          }
                                          list.Add((T)t);
                                    };
                              }
                              return list;

                        }
                  }
                  catch (Exception ex)
                  {
                        Console.WriteLine(ex.Message);
                        return list;
                  }
            }
            public static DataTable Executor(SqlCommand cmd)
            {
                  DataTable dt = null;
                  SqlDataAdapter adapter = null;
                  try
                  {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                              cmd.Connection = connection;
                              adapter = new SqlDataAdapter(cmd);
                              dt = new DataTable("Table");
                              adapter.Fill(dt);
                              return dt;
                        }

                  }
                  catch (Exception ex)
                  {
                        Console.WriteLine(ex.Message);
                        return dt;
                  }

            }

            public static bool NonQuery(SqlCommand cmd)
            {
                  try
                  {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                              cmd.Connection = connection;
                              connection.Open();
                              return cmd.ExecuteNonQuery() <= 0 ? false : true;
                        }
                  }
                  catch (Exception ex)
                  {
                        Console.WriteLine(ex.Message);
                        return false;
                  }
            }
      }
}