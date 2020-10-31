using ControleAdornos.Repositorios;
using System;
using System.Windows.Forms;

namespace ControleAdornos.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            RepositorioMontaDados montaDados = new RepositorioMontaDados();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FechaFormAberto();

            FrmMaterial frmMateriais = new FrmMaterial();
            frmMateriais.MdiParent = this;
            frmMateriais.Show();
        }

        private void FechaFormAberto()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FechaFormAberto();

            FrmPalavras frmPalavras = new FrmPalavras();
            frmPalavras.MdiParent = this;
            frmPalavras.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FechaFormAberto();

            FrmTipo_Material frmTipo_Material = new FrmTipo_Material();
            frmTipo_Material.MdiParent = this;
            frmTipo_Material.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FechaFormAberto();

            FrmCor frmCor = new FrmCor();
            frmCor.MdiParent = this;
            frmCor.Show();
        }
    }
}
