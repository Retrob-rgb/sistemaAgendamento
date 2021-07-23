using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ConsultorioMedico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_busca_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=pescaria;uid=root;pwd=''");
                conexao.Open();

                String pescador = txt_pescador.Text.Trim();
                String sql = String.Format("select cpf, nome from pescador where nome like'%{0}%' or cpf like'%{0}%'", pescador);

                DataSet resultado = new DataSet();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                consulta.Fill(resultado, "pescador");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "pescador";

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_busca_medico_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=pescaria;uid=root;pwd=''");
                conexao.Open();

                String quiosque = txt_quiosque.Text.Trim();
                String sql = String.Format("select crm, nome, finalidade from quiosque where nome like'%{0}%' or crm like'%{0}%' or finalidade like'%{0}%'", quiosque);

                DataSet resultado = new DataSet();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                consulta.Fill(resultado, "quiosque");

                dataGridView2.DataSource = resultado;
                dataGridView2.DataMember = "quiosque";

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=pescaria;uid=root;pwd=''");
                conexao.Open();

                int linhapescador = dataGridView1.CurrentRow.Index;
                String cpf = dataGridView1[0, linhapescador].Value.ToString();

                int linhaquiosque = dataGridView2.CurrentRow.Index;
                String crm = dataGridView2[0, linhaquiosque].Value.ToString();

                string data = txt_data.Text.Trim();
                string hora = txt_horario.Text.Trim();
                string obs = txt_obs.Text.Trim();

                /* verificar se já tem agenda nesta data e horario para o médico
                 * 
                */
                String sqlverifica = String.Format("SELECT COUNT(*) AS TOTAL FROM AGENDA WHERE CRM = '{0}' AND DATE_FORMAT(data, '%d/%m/%Y') = '{1}' and DATE_FORMAT(hora, '%H:%i') = '{2}'; ", crm, data, hora);

                MySqlCommand executa = new MySqlCommand(sqlverifica, conexao);

                MySqlDataReader resultado = executa.ExecuteReader();

                resultado.Read();

                int total = resultado.GetInt32("TOTAL");
                if (total == 0)
                {
                    String sql = String.Format("insert into agenda (data, hora, cpf, crm, observacao) values (str_to_date('{0}','%d/%m/%Y'),'{1}','{2}','{3}','{4}');", data, hora, cpf, crm, obs);

                    conexao = new MySqlConnection("server=localhost;database=pescaria;uid=root;pwd=''");
                    conexao.Open();
                    MySqlCommand executar = new MySqlCommand(sql, conexao);
                    executar.ExecuteNonQuery();
                    MessageBox.Show("Quiosque agendado com sucesso!");

                   
                    txt_horario.Text="";
                    txt_obs.Clear();
                    txt_pescador.Clear();
                    txt_quiosque.Clear();
                    dataGridView1.DataSource = null;
                    dataGridView2.DataSource = null;

                    txt_pescador.Focus();
                }
                else
                {
                    MessageBox.Show("Este quiosque já está reservado para esta data e horário !");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        
    }
}
