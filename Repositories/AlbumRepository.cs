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

        public bool AddAlbum(AlbumModel album)
        {
            using (SqlConnection conexao = new SqlConnection(Conexao.GetConnectionString()))
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
                    int linhaDaTabela = sqlCmd.ExecuteNonQuery();

                    if (linhaDaTabela >= 1)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}