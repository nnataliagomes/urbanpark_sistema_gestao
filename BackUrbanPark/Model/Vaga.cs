using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUrbanPark.Model
{
    public class Vaga
    {
        private int _id;
        private string _numero_vaga;
        private TipoVaga _tipoVaga;
        private TipoStatus _tipoStatus;


        public Vaga(int id, string numero_vaga, TipoVaga tipoVaga, TipoStatus tipoStatus)
        {
            Id = id;
            Numero_vaga = numero_vaga;
            TipoVaga = tipoVaga;
            TipoStatus = tipoStatus;
        }

        public Vaga(string numero_vaga, TipoVaga tipoVaga, TipoStatus tipoStatus)
        {
            Numero_vaga = numero_vaga;
            TipoVaga = tipoVaga;
            TipoStatus = tipoStatus;
        }

        public int Id { get => _id; set => _id = value; }
        public string Numero_vaga { get => _numero_vaga; set => _numero_vaga = value; }
        public TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
        public TipoStatus TipoStatus { get => _tipoStatus; set => _tipoStatus = value; }
    }
}
