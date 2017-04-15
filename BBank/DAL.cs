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
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public List<ContaModelo> listarConta()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);
            List<ContaModelo> contas = new List<ContaModelo>();

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "SELECT * FROM CONTA;";

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ContaModelo conta = new ContaModelo();
                        conta.numero = dr["NUMERO"].ToString();
                        conta.agencia = dr["AGENCIA"].ToString();
                        conta.saldo = Convert.ToDecimal(dr["SALDO"]);
                        conta.tipo = Convert.ToChar(dr["TIPO"]);

                        contas.Add(conta);
                    }
                }

                return contas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
