using ControleAdornos.Entidades;
using ControleAdornos.Repositorios;
using ControleAdornos.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControleAdornos
{
    public partial class FrmPalavras : Form
    {
        readonly CorRepositorio corRepositorio = new CorRepositorio();
        readonly PalavraRepositorio PalavraRepositorio = new PalavraRepositorio();
        readonly MaterialRepositorio MaterialRepositorio = new MaterialRepositorio();
        List<Palavra> lstPalavras = new List<Palavra>();
        readonly Utils Utils = new Utils();
        private List<Cor> cores;
        private List<Label> lstLabels;

        public string palavraSelecionada { get; private set; }

        public FrmPalavras()
        {
            InitializeComponent();
        }

        private void FrmPalavras_Load(object sender, EventArgs e)
        {
            AtualizaTela();
        }

        private void PreencheCombo()
        {
            if (cmbCores.Items.Count == 0)
            {
                cores = corRepositorio.Obter();
                cmbCores.DataSource = cores;
                cmbCores.ValueMember = "Id";
                cmbCores.DisplayMember = "Descricao";
            }
        }

        private void AtualizaTela()
        {
            lstPalavras = PalavraRepositorio.Obter().ToList();
            List<string> lista = lstPalavras.Select(palavra => palavra.Descricao).ToList();

            dgvPalavras.DataSource = PalavraRepositorio.Obter();
            dgvPalavras.Columns["Id"].Visible = false;
            dgvPalavras.Columns["DescricaoAntiga"].Visible = false;


            txtPalavra.Text = "";
            lblTotal.Text = $"Total: {lstPalavras.Count()}";

            PreencheCombo();
            AtualizaContagemLetras(lista);
        }

        private void AtualizaContagemLetras(List<string> palavras)
        {
            MontaListaLetras();

            // Monta indicadores
            foreach (KeyValuePair<string, int> letra in Utils.CalculaQtdeLetras(palavras))
            {
                lstLabels.FirstOrDefault(lbl => lbl.Name.Substring(lbl.Name.Length - 1) == letra.Key).Text = letra.Value.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var palavra = txtPalavra.Text.ToUpper();

            if (palavra == string.Empty) return;

            var retorno = MessageBox.Show($"Confirma inclusão da palavra '{palavra}' ?", "Adicionar", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                if (MaterialRepositorio.AtualizaEstoqueLetras(new Palavra(null, palavra)))
                {
                    PalavraRepositorio.Inserir(palavra);
                    AtualizaTela();
                }
                else
                {
                    MessageBox.Show($"Não há materiais suficiente para a palavra '{palavra}'. Inclusão não realizada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var palavraApagar = palavraSelecionada;
            if (string.IsNullOrWhiteSpace(palavraApagar)) return;

            var retorno = MessageBox.Show($"Confirma remoção da palavra '{palavraApagar}' ?", "Remover", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                Palavra palavra = new Palavra(
                    lstPalavras.Where(s => s.Descricao == palavraApagar).FirstOrDefault().Id,
                    string.Empty)
                {
                    DescricaoAntiga = palavraApagar
                };

                PalavraRepositorio.Remover(palavra);
                MaterialRepositorio.AtualizaEstoqueLetras(palavra);
                AtualizaTela();
            }
        }

        private void dgvMateriais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizaObjetos();
        }

        private void AtualizaObjetos()
        {
            palavraSelecionada = dgvPalavras.Rows[dgvPalavras.CurrentCell.RowIndex].Cells["Descricao"].Value.ToString();
            txtPalavra.Text = palavraSelecionada;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalavra.Text)) return;

            Palavra palavra = new Palavra(
                lstPalavras.Where(s => s.Descricao == palavraSelecionada).FirstOrDefault().Id,
                txtPalavra.Text.Trim())
            {
                DescricaoAntiga = palavraSelecionada
            };

            var retorno = MessageBox.Show($"Confirma alteração da palavra '{palavra.DescricaoAntiga}' para '{palavra.Descricao}'? Isso irá alterar o estoque de letras.", "Alterar", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                PalavraRepositorio.Alterar(palavra);
                MaterialRepositorio.AtualizaEstoqueLetras(palavra);
                AtualizaTela();
            }
        }

        private void cmbCores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cores != null && cmbCores.Items.Count > 0)
            {
                var cor = (int)cores.Where(w => w.Id == (int)cmbCores.SelectedValue).Select(s => s.ValorARBG).FirstOrDefault();
                pnlCor.BackColor = Color.FromArgb(cor);
            }
        }

        private void MontaListaLetras()
        {
            lstLabels = new List<Label>();
            lstLabels.Add(letraA);
            lstLabels.Add(letraB);
            lstLabels.Add(letraC);
            lstLabels.Add(letraD);
            lstLabels.Add(letraE);
            lstLabels.Add(letraF);
            lstLabels.Add(letraG);
            lstLabels.Add(letraH);
            lstLabels.Add(letraI);
            lstLabels.Add(letraJ);
            lstLabels.Add(letraK);
            lstLabels.Add(letraL);
            lstLabels.Add(letraM);
            lstLabels.Add(letraN);
            lstLabels.Add(letraO);
            lstLabels.Add(letraP);
            lstLabels.Add(letraQ);
            lstLabels.Add(letraR);
            lstLabels.Add(letraS);
            lstLabels.Add(letraT);
            lstLabels.Add(letraU);
            lstLabels.Add(letraV);
            lstLabels.Add(letraW);
            lstLabels.Add(letraX);
            lstLabels.Add(letraY);
            lstLabels.Add(letraZ);

            lstLabels.ForEach(i => i.Text = "0");
        }

    }
}
