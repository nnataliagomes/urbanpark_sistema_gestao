using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace BackUrbanPark.Repository
{
    public class VagaRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vaga"></param>
        /// <returns></returns>


        public int Inserir(Vaga vaga)
        {
            return 1;
        }

        public Vaga? BuscarPorId(int id)
        {
            string sql = "SELECT id_vaga, numero_vaga, tipo, status FROM vagas Where id = @id";

            using (var cmd = new MySqlCommand(sql))
            {
                cmd.Paramaters.AddWithValue("@id", id);
                using (var reader = Banco.ExecutarConsulta(cmd))
                {
                    if (reader.Read())
                    {
                        /// mapeamento do retorno do banco para objeto vaga
                        int id_vaga = reader.GetInt32("id_vaga");
                        int numero_vaga = reader.GetInt32("numero_vaga");
                        TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader.GetString("tipo"));
                        TipoStatus tipoStatus = Enum.Parse<TipoStatus>(reader.GetString("status"));

                        Vaga vagaBanco = new Vaga(id_vaga, numero_vaga, tipoVaga, tipoStatus);
                    }  
                }
            }
        }
    }
}
