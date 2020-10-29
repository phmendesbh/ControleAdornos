using ControleAdornos.Entidades;
using ControleAdornos.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComponenteCor
{
    public partial class UC_Cor : UserControl
    {
        public List<Cor> cores = new List<Cor>();
        readonly CorRepositorio corRepositorio = new CorRepositorio();


        public UC_Cor()
        {
            InitializeComponent();
        }

        private void cmbCores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cores != null && cmbCores.Items.Count > 0)
            {
                var cor = (int)cores.Where(w => w.Id == (int)cmbCores.SelectedValue).Select(s => s.ValorARBG).FirstOrDefault();
                pnlCor.BackColor = Color.FromArgb(cor);
            }
        }

        private void UC_Cor_Load(object sender, EventArgs e)
        {
            cores = corRepositorio.Obter();
            cmbCores.DataSource = cores;
            cmbCores.ValueMember = "Id";
            cmbCores.DisplayMember = "Descricao";
        }
    }
}
