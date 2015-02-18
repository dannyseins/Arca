using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Verdezul.IDH.DataAccess
{
    public class GenericDataAccess
    {
        protected SqlParameter SqlParameterInput(string nombre, object valor)
        {
            SqlParameter sqlp = new SqlParameter(nombre, valor);
            sqlp.Direction = ParameterDirection.Input;
            return sqlp;
        }

        protected SqlParameter SqlParameterOutput(string nombre, DbType dbType)
        {
            SqlParameter sqlp = new SqlParameter();
            sqlp.ParameterName = nombre;
            sqlp.Direction = ParameterDirection.Output;
            sqlp.DbType = dbType;
            return sqlp;
        }

        protected SqlParameter SqlParameterOutput(string nombre, SqlDbType sqlDbType, int tamano)
        {
            SqlParameter sqlp = new SqlParameter(nombre, sqlDbType, tamano);
            sqlp.Direction = ParameterDirection.Output;
            return sqlp;
        }

        protected SqlParameter SqlParameterReturn()
        {
            return SqlParameterReturn("ReturnValue");
        }

        protected SqlParameter SqlParameterReturn(string nombre)
        {
            SqlParameter sqlp = new SqlParameter();
            sqlp.ParameterName = nombre;
            sqlp.Direction = ParameterDirection.ReturnValue;
            return sqlp;
        }

        protected object ValorEnteroNulo(int valorEntero)
        {
            if (valorEntero == 0)
                return DBNull.Value;
            return valorEntero;
        }

        protected object ValorFechaNulo(DateTime valorFecha)
        {
            if (valorFecha == new DateTime())
                return DBNull.Value;
            return valorFecha;
        }
    }
}
