using SistemaFooFaMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public List<AlbumModel> GetAllAlbuns()
        {
            using(SqlConnection conexao = new SqlConnection(Conexao.GetConnectionString()))
            {
                List<AlbumModel> albumList = new List<AlbumModel>();

                string sql = @"SELECT * FROM Album";

                using (SqlCommand sqlCmd = new SqlCommand(sql, conexao))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                    DataTable dt = new DataTable();
                    
                    conexao.Open();
                    da.Fill(dt);

                    foreach (DataRow linha in dt.Rows)
                    {
                        albumList.Add(
                            new AlbumModel
                            {
                                Id = Convert.ToInt32(linha["Id"]),
                                Titulo = Convert.ToString(linha["Titulo"]),
                                Lancamento = Convert.ToInt32(linha["Lancamento"]),
                                Imagem = Convert.ToString(linha["Imagem"]),
                                Descricao = Convert.ToString(linha["Descricao"])
                            }
                            );
                    }

                    return albumList;
                }
            }
        }
    }
}