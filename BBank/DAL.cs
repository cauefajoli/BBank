using BBank.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank
{
    class DAL
    {
        String conMySQL = "server=localhost; user id=BBANK; password=FAJOLI; database=BBANKSYSTEM";


        public bool cadastrarConta(ContaModelo conta)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);
            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "INSERT INTO CONTA VALUES (@NUMERO,@AGENCIA,@TIPO,@SALDO);";
                cmd.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = conta.numero;
                cmd.Parameters.Add("@AGENCIA", MySqlDbType.VarChar).Value = conta.agencia;
                cmd.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = conta.tipo;
                cmd.Parameters.Add("@SALDO", MySqlDbType.Decimal).Value = conta.saldo;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
    }
}
