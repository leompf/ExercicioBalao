using Bibliotecas;

namespace ExercicioBalao.Forms
{
    public partial class FrmBalao : Form
    {
        Balao _balao;

        public FrmBalao()
        {
            InitializeComponent();

            string[] cores = { "vermelho", "verde", "azul", "amarelo" };

            foreach (string cor in cores)
            {
                cbbCor.Items.Add(cor);
            }                  
        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            if (cbbCor.SelectedItem != null)
            {
                _balao = new Balao(cbbCor.SelectedItem.ToString());
                lblMensagem.Text = $"Foi construído um balão {_balao.Cor}.";
                btnConstruir.Enabled = false;
                btnMudarCor.Enabled = true;
                grpboxBalao.Enabled = true;
                lblAltura.Text = $"{_balao.Altura}m";               
            }
            else
            {
                lblMensagem.Text = $"Por favor defina a cor do seu balão.";
            }
        }

        private void btnDiminuiAltura_Click(object sender, EventArgs e)
        {
            _balao.Altura--;
            lblAltura.Text = $"{_balao.Altura}m";
        }

        private void btnAumentaAltura_Click(object sender, EventArgs e)
        {
            _balao.Altura++;
            lblAltura.Text = $"{_balao.Altura}m";
        }

        private void btnDescer_Click(object sender, EventArgs e)
        {
            _balao.Altura = 0;
            lblAltura.Text = $"{_balao.Altura}m";
        }

        private void ModificarBalao()
        {
            if (_balao.Altura == 0)
            {
                _balao.Cor = cbbCor.SelectedItem.ToString();
                lblMensagem.Text = $"A cor do balão é agora {_balao.Cor}.";
            }
            else
            {
                lblMensagem.Text = $"A cor do balão não pode ser mudada no ar!";
            }
        }

        private void btnMudarCor_Click(object sender, EventArgs e)
        {
            ModificarBalao();
        }

        private void lblAltura_TextChanged(object sender, EventArgs e)
        {
            if (_balao.Altura != 0)
            {
                rbtnEste.Enabled = true;
                rbtnOeste.Enabled = true;
                rbtnNorte.Enabled = true;
                rbtnSul.Enabled = true;
            }
            else
            {
                rbtnEste.Enabled = false;
                rbtnOeste.Enabled = false;
                rbtnNorte.Enabled = false;
                rbtnSul.Enabled = false;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radiobutton = (RadioButton)sender;

            if (radiobutton.Checked)
            {
                _balao.Direcao = radiobutton.Text;
                lblDirecao.Text = $"A direção do balão é {_balao.Direcao}.";
            }
        }

        private void RadioButton_EnabledChanged(object sender, EventArgs e)
        {
            var radiobutton = (RadioButton)sender;

            if (radiobutton.Enabled == false)            
                lblDirecao.Text = $"O balão não está a voar!";           
            else
            {
                if (_balao.Direcao == null)
                    lblDirecao.Text = "";
                else
                    lblDirecao.Text = $"A direção do balão é {_balao.Direcao}.";
            }
        }
    }
}
