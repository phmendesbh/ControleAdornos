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

        public Palavra palavraSelecionada { get; private set; }

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
            lstPalavras = PalavraRepositorio.Obter();
            List<string> lista = lstPalavras.Select(palavra => palavra.Descricao).ToList();

            txtPalavra.Text = "";
            lblTotal.Text = $"Total: {lstPalavras.Count()}";

            PreencheCombo();
            AtualizaContagemLetras(lista);

            MontaGrid(lstPalavras);

            palavraSelecionada = new Palavra();
        }

        private void MontaGrid(List<Palavra> lstPalavras)
        {
            var listaGrid = lstPalavras.Select(p => new { p.Id, Palavra = p.Descricao, Cor = p.Cor.Descricao, Cor_Id = p.Cor.Id, Cor_ValorARGB = p.Cor.ValorARBG }).ToList();

            dgvPalavras.DataSource = listaGrid;
            dgvPalavras.Columns["Id"].Visible = false;
            dgvPalavras.Columns["Cor_Id"].Visible = false;
            dgvPalavras.Columns["Cor_ValorARGB"].Visible = false;
        }

        private void dgvPalavras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizaObjetos();
        }

        private void AtualizaObjetos()
        {
            palavraSelecionada = new Palavra()
            {
                Id = (int)dgvPalavras.Rows[dgvPalavras.CurrentCell.RowIndex].Cells["Id"].Value,
                Descricao = dgvPalavras.Rows[dgvPalavras.CurrentCell.RowIndex].Cells["Palavra"].Value.ToString(),
                Cor = new Cor()
                {
                    Id = (int)dgvPalavras.Rows[dgvPalavras.CurrentCell.RowIndex].Cells["Cor_Id"].Value
                }
            };

            txtPalavra.Text = palavraSelecionada.Descricao;
            cmbCores.SelectedValue = palavraSelecionada.Cor.Id;
            var corSelecionada = (int)cores.Where(w => w.Id == palavraSelecionada.Cor.Id)
                                            .Select(s => s.ValorARBG).FirstOrDefault();
            pnlCor.BackColor = Color.FromArgb(corSelecionada);
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
            var palavra = new Palavra()
            {
                Id = null,
                Descricao = txtPalavra.Text.ToUpper(),
                Cor = new Cor()
                {
                    Id = (int)cmbCores.SelectedValue
                }
            };

            if (palavra.Descricao == string.Empty) return;

            var retorno = MessageBox.Show(ResourceMensagensPadrao.CONFIRMA_INCLUSAO, "Adicionar", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                if (MaterialRepositorio.AtualizaEstoqueLetras(palavra))
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
            var palavraApagar = palavraSelecionada.Descricao;
            if (string.IsNullOrWhiteSpace(palavraApagar)) return;

            var retorno = MessageBox.Show($"{ResourceMensagensPadrao.CONFIRMA_REMOCAO}  Isso irá alterar o estoque de letras.", "Remover", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                PalavraRepositorio.Remover(palavraSelecionada);
                MaterialRepositorio.AtualizaEstoqueLetras(palavraSelecionada);
                AtualizaTela();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalavra.Text)) return;

            Palavra palavra = new Palavra()
            {
                Id = lstPalavras.Where(s => s.Descricao == palavraSelecionada.Descricao).FirstOrDefault().Id,
                Descricao = txtPalavra.Text,
                DescricaoAntiga = palavraSelecionada.Descricao,
                Cor = new Cor()
                {
                    Id = (int)cmbCores.SelectedValue
                }
            };

            var retorno = MessageBox.Show($"{ResourceMensagensPadrao.CONFIRMA_ALTERACAO} Isso irá alterar o estoque de letras.", "Alterar", MessageBoxButtons.YesNo);

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
