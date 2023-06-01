using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studant_menager
{

    internal class MEU_BD
    {
        private MySqlConnection conexao = null MySqlConnection("datasource=localhost;username=root;password=;database=t4_sga_bd");

        private MySqlDataReader getConexao
        {
            get
            {
                return conexao;
            }
        }
        public void abrirConexao()
        {
            if ( conexao.State == Connectionstate.Open)
        }
    }   
