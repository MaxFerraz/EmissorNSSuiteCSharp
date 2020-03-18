using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace EmissorNSSuiteCSharp.Banco
{
    class ConexaoBanco
    {
        public SQLiteConnection connection;
        public DataTable dataTable;
        public DataSet dataSet;
        public SQLiteDataAdapter dataAdapter;
        public SQLiteDataReader dataReader;
        public SQLiteCommandBuilder commandBuilder;
        public int CountSQL;

        private String server = "Data Source=BancoSat.db";
        private String database = "BancoSat.db";

        public void Conectar()
        {
            if (connection != null)
            {
                connection.Close();
            }

            try
            {
                if (!File.Exists(database))
                {
                    SQLiteConnection.CreateFile(database);
                    connection = new SQLiteConnection(server);
                    connection.Open();

                    StringBuilder sqlCadDestinatario = new StringBuilder();
                    sqlCadDestinatario.AppendLine("CREATE TABLE IF NOT EXISTS CAD_PRODUTOS([CODPRODUTO] INTEGER PRIMARY KEY AUTOINCREMENT,)");
                    sqlCadDestinatario.AppendLine("[CODIGO_BARRAS] INTEGER,");
                    sqlCadDestinatario.AppendLine("[DESCRICAO] VARCHAR(100),");
                    sqlCadDestinatario.AppendLine("[CFOP] VARCHAR(5),");
                    sqlCadDestinatario.AppendLine("[NCM] VARCHAR(8),");
                    sqlCadDestinatario.AppendLine("[CEST] VARCHAR(8),");
                    sqlCadDestinatario.AppendLine("[VALOR_APROX] DECIMAL(10,4),");
                    sqlCadDestinatario.AppendLine("[ISAT] INTEGER,");
                    sqlCadDestinatario.AppendLine("[UNID_COMERC] VARCHAR(4),");
                    sqlCadDestinatario.AppendLine("[CUSTO_UNIT] DECIMAL(10,4),");
                    sqlCadDestinatario.AppendLine("[QUANT] DECIMAL(10,4),");
                    sqlCadDestinatario.AppendLine("[ORIGEM] INTEGER)");
                }


            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //metodo ExecutaSQL é usado toda que vez que realiza algum insert, update, delete ou consulta no banco
        public void EnviandoBanco(string comandoSql)
        {
            SQLiteCommand comando = new SQLiteCommand(comandoSql, connection);
            comando.ExecuteNonQuery();
            connection.Close();

        }

    }
}
