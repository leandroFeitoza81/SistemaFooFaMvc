using SistemaFooFaMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Repositories
{
    public class AlbumRepository
    {

       // private SqlConnection conexao;

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["FooFighters"].ConnectionString;
        }

        public bool AddAlbum(AlbumModel album)
        {
            using (SqlConnection conexao = new SqlConnection(GetConnectionString()))
            {
                string sql = @"INSERT INTO Album" +
                    "(Titulo, Lancamento)" +
                    "VALUES" +
                    "(@Titulo, @Lancamento)";

                using(SqlCommand sqlCmd = new SqlCommand(sql, conexao))
                {
                    sqlCmd.Parameters.AddWithValue("@Titulo", album.Titulo);
                    sqlCmd.Parameters.AddWithValue("@Lancamento", album.Lancamento);

                    conexao.Open();
                    int i = sqlCmd.ExecuteNonQuery();

                    if (i >= 1)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}