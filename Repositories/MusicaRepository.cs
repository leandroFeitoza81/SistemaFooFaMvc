using SistemaFooFaMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Repositories
{
    public class MusicaRepository
    {
        public bool AddMusica(MusicaModel musica)
        {
            using (SqlConnection conexao = new SqlConnection(Conexao.GetConnectionString()))
            {
                string sql = @"INSERT INTO Musica" +
                    "(Titulo, Single, Id_Album)" +
                    "VALUES" +
                    "(@Titulo, @Single, @ID_Album)";

                using (SqlCommand sqlCmd = new SqlCommand(sql, conexao))
                {
                    sqlCmd.Parameters.AddWithValue("@Titulo", musica.Titulo);
                    sqlCmd.Parameters.AddWithValue("@Single", musica.Single);
                    sqlCmd.Parameters.AddWithValue("@Id_Album", musica.Id_Album);

                    conexao.Open();
                    int i = sqlCmd.ExecuteNonQuery();

                    if (i >= 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }
    }
}