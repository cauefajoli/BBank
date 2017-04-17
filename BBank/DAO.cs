using BBank.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBank
{
    class DAO
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
                cmd.CommandText = "SELECT * FROM CONTA WHERE ATIVA = 1;";

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
                        conta.ativa = Convert.ToInt32(dr["ATIVA"]);

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
        public bool encerrarConta(String numero)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "SELECT SALDO FROM CONTA WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = numero;

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (Convert.ToDecimal(dr["SALDO"]) > 0)
                {
                    return false;
                }
                else    
                {
                    dr.Close();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE CONTA SET ATIVA = 0 WHERE NUMERO = @NUMERO;";
                    cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = numero;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ContaModelo RetornaConta(String numero)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);
            ContaModelo contaModelo = new ContaModelo();
            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "SELECT * FROM CONTA WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = numero;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (Convert.ToChar(dr["TIPO"]) == 'C')
                    {
                        ContaCorrente conta = new ContaCorrente();
                        conta.numero = dr["NUMERO"].ToString();
                        conta.agencia = dr["AGENCIA"].ToString();
                        conta.tipo = 'C';
                        conta.saldo = Convert.ToDecimal(dr["SALDO"]);
                        return conta;
                    }
                    else
                    {
                        ContaPoupanca conta = new ContaPoupanca();
                        conta.numero = dr["NUMERO"].ToString();
                        conta.agencia = dr["AGENCIA"].ToString();
                        conta.tipo = 'P';
                        conta.saldo = Convert.ToDecimal(dr["SALDO"]);
                        return conta;
                    }
                }
                else
                    return contaModelo;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Connection.Clone();
            }
        }
        public bool transferir(ContaModelo contaOrigem,ContaModelo contaDestino)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);

            try
            {
                cmd.Connection.Open();
                cmd.Transaction = cmd.Connection.BeginTransaction();
                cmd.CommandText = "UPDATE CONTA SET SALDO = @SALDO WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@SALDO", MySqlDbType.Decimal).Value = contaOrigem.saldo;
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = contaOrigem.numero;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE CONTA SET SALDO = @SALDO WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@SALDO", MySqlDbType.Decimal).Value = contaDestino.saldo;
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = contaDestino.numero;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                cmd.Transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }
        public bool depositar(ContaModelo conta)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "UPDATE CONTA SET SALDO = @SALDO WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@SALDO", MySqlDbType.Decimal).Value = conta.numero;
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = conta.saldo;
                cmd.ExecuteNonQuery();
                return true;
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
        public bool atualizarSaldo(ContaModelo conta)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection(conMySQL);

            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "UPDATE CONTA SET SALDO = @SALDO WHERE NUMERO = @NUMERO";
                cmd.Parameters.Add("@SALDO", MySqlDbType.Decimal).Value = conta.saldo;
                cmd.Parameters.Add("@NUMERO", MySqlDbType.String).Value = conta.numero;
                cmd.ExecuteNonQuery();
                return true;
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
    }
}
