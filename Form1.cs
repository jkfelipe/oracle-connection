namespace TesteWindowsForms2
{
    using System.Data;
    using System.Windows.Forms;
    using Oracle.ManagedDataAccess.Client;
    using DotNetEnv;
    using static System.ComponentModel.Design.ObjectSelectorEditor;

    public partial class Form1 : Form
    {
        private OracleConnection connection;

        public Form1()
        {
            InitializeComponent();
            Env.TraversePath().Load();

            //MessageBox.Show($"Usuário: {Environment.GetEnvironmentVariable("DB_USER")}");
        }


        private string GetConnectionString()
        {
            string db_user = Environment.GetEnvironmentVariable("DB_USER");
            string db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string db_host = Environment.GetEnvironmentVariable("DB_HOST");
            string db_port = Environment.GetEnvironmentVariable("DB_PORT");
            string db_service_name = Environment.GetEnvironmentVariable("DB_SERVICE_NAME");

            return $"User Id={db_user};Password={db_password};Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={db_host})(PORT={db_port}))(CONNECT_DATA=(SERVICE_NAME={db_service_name})));";
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();

            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();

                lblStatus.Text = "Conectado";
                //MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Erro ao conectar: {ex.Message}";
            }

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection = null; // Libera a referência
                    lblStatus.Text = "Conexão encerrada com sucesso!";
                    //MessageBox.Show("Conexão encerrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Nenhuma conexão ativa para encerrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = "Nenhuma conexão ativa para encerrar.";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Erro ao desconectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Erro ao desconectar: {ex.Message}";
            }
        }

        protected void button3_Click(object sender, EventArgs e)
        {

            if (connection == null || connection.State != ConnectionState.Open)
            {
                lblStatus.Text = "A conexão com o banco não está aberta.";
                return;
            }

            string query = "SELECT * FROM coordem FETCH FIRST 10 ROWS ONLY"; //Query de teste

            try
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Vincula os dados ao DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }                
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Erro ao carregar dados: {ex.Message}";
            }
        }
    }
}
