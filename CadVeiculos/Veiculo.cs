using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeiculos
{
    class Veiculo
    {
        private const string connectionString = "Server=localhost;Database=senai;User id = senai; Password=Senai1234";
        private string placa, modelo;

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public string Inserir()
        {
            MySqlConnection con =
                new MySqlConnection(connectionString);

            try
            {
                con.Open();

                MySqlCommand query = new MySqlCommand("INSERT INTO veiculo VALUES(@placa,@modelo)", con);
                query.Parameters.AddWithValue("@placa", placa);
                query.Parameters.AddWithValue("@modelo", modelo);

                query.ExecuteNonQuery();

                con.Close();

                return "Inserido com sucesso!";
            }
            catch (Exception ex)
            {
                return "ERRO: " + ex.Message;
            }
        }

        public string Excluir()
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();

                MySqlCommand query = new MySqlCommand("DELETE FROM veiculo WHERE Placa = @placa", con);
                query.Parameters.AddWithValue("@placa", placa);

                query.ExecuteNonQuery();

                con.Close();

                return "Excluido com sucesso!";                
            }
            catch (Exception ex)
            {
                return "ERRO: " + ex.Message;
            }
        }

        public static List<Veiculo> listaVeiculos()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            List<Veiculo> lista = new List<Veiculo>();
            

            try
            {
                con.Open();

                MySqlCommand query = new MySqlCommand("SELECT * FROM veiculo", con);
                MySqlDataReader leitor = query.ExecuteReader();

                //percorrer o resultado
                while (leitor.Read())
                {
                    //criar o item da lista
                    Veiculo item = new Veiculo();
                    item.Placa = leitor["placa"].ToString();
                    item.Modelo = leitor["modelo"].ToString();

                    lista.Add(item);
                }

                con.Close();                
            }
            catch (Exception ex)
            {
                lista = null;
            }

            return lista;
        }
    }
}
