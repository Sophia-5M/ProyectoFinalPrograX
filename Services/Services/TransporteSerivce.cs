using Dapper;
using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Transporte
{
    public class TransporteSerivce : ITransporte
    {
        public void DeleteTransporte(int id)
        {
            throw new NotImplementedException();
        }

        public void EditTransporte(tbl_transporteModel categoria)
        {
            throw new NotImplementedException();
        }

        public List<tbl_transporteModel> EditTransporte(IDbConnection connection, int id_transporte)
        {
            throw new NotImplementedException();
        }

        public tbl_transporteModel GetTransporte()
        {
            throw new NotImplementedException();
        }

        public List<tbl_transporteModel> GetTransporteByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<tbl_transporteModel> GetTransportes()
        {
            throw new NotImplementedException();
        }

        public List<tbl_transporteModel> GetTransportes(IDbConnection connection)
        {
            return (List<tbl_transporteModel>)connection.Query<tbl_transporteModel>("SELECT * FROM tbl_transporte");
        }

        public void SetTransporte(tbl_transporteModel categoria)
        {
            throw new NotImplementedException();
        }
    }
}
