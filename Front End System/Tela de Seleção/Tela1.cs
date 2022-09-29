using Front_End_System.Tela_de_Seleção;

namespace Front_End_System {
    public partial class Tela1 : Form {
        public Tela1() {
            InitializeComponent();
            MessageBox.Show("Powered by 'Natzun' shyland");
        }

        private void Tela1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (comboBox1.Text == "Fundamentos") {
                var telaFundamentos = new TelaFundamentos();
                telaFundamentos.ShowDialog();
            } else {
                if (comboBox1.Text == "") {
                    MessageBox.Show("Selecione um módulo");
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }
    }
}