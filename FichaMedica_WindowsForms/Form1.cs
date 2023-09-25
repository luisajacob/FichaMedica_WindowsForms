using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace N2_2B_Alg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            //Criar um objeto usando as informações inseridas nas caixas de texto da ficha
            Paciente paciente = new Paciente(txtNome1.Text, txtRG.Text, txtCpf.Text, txtTelefone1.Text);

            {
                if (string.IsNullOrEmpty(txtNome1.Text) || string.IsNullOrEmpty(txtRG.Text) || string.IsNullOrEmpty(txtCpf.Text) 
                    || string.IsNullOrEmpty(txtTelefone1.Text) || !checkATESTO.Checked)
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Cancela o envio dos dados
                }

                // Se todos os campos estão preenchidos, você pode prosseguir com o envio dos dados
                else
                {
                    //método para exibir as informações do paciente após o envio da ficha
                    MessageBox.Show(paciente.RetornarInfo(), "Ficha Médica cadastrada com sucesso. \nPaciente:");
                }
            }
        }

        private void buttonNovaFicha_Click(object sender, EventArgs e)
        {
            txtNome1.Text = "";
            listNaturalidade.Text = "";
            txtRG.Text = "";
            txtCpf.Text = "";
            txtTelefone1.Text = "";
            txtEndereco.Text = "";
            txtPlanoSaude.Text = "";
            txtQual1.Text = "";
            txtQual2.Text = "";
            txtQual3.Text = "";
            txtNome2.Text = "";
            txtTelefone2.Text = "";
            checkATESTO.Checked = !checkATESTO.Checked;
            dateNasc.Value = dateAtual.Value;

            if (checkAp.Checked || checkAn.Checked || checkBp.Checked || checkBn.Checked || checkABp.Checked || checkABn.Checked || checkOp.Checked || checkOn.Checked 
                || checkSIM1.Checked || checkSIM2.Checked || checkSIM3.Checked || checkNAO1.Checked || checkNAO2.Checked || checkNAO3.Checked)
            {
                checkAp.Checked = false;
                checkAn.Checked = false;
                checkBp.Checked = false;
                checkBn.Checked = false;
                checkABp.Checked = false;
                checkABn.Checked = false;
                checkOp.Checked = false;
                checkOn.Checked = false;
                checkSIM1.Checked = false;
                checkSIM2.Checked = false;
                checkSIM3.Checked = false;
                checkNAO1.Checked = false;
                checkNAO2.Checked = false;
                checkNAO3.Checked = false;
            }
        }
    }
}
