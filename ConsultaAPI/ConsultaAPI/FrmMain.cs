using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace ConsultaAPI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(texCEP.Text))
            {
                MessageBox.Show("Digite o CEP", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(texCEP.Text);

                    if (retorno is null)
                    {
                        MessageBox.Show("O CEP Não Foi Localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    textUf.Text = retorno.uf;
                    textCidade.Text = retorno.cidade;
                    textBairro.Text = retorno.bairro;
                    textEndereco.Text = retorno.end;
                    textComp1.Text = retorno.complemento;
                    textComp2.Text = retorno.complemento2;
                    //textPostagem.Text = retorno.unidadesPostagem;
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Erro Ao Consultar O CEP " + 
                        Error.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void texCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }
    }
}
