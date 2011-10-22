using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFMVC.Windows.Forms;
using SampleFormApplication.Model;

namespace SampleFormApplication
{
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cria uma instância de usuário baseada nos controles do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modelo_Click(object sender, EventArgs e)
        {
            Usuario usuario = this.Model<Usuario>();
        }

        /// <summary>
        /// Preenche os dados do formulário com a instância do usuário criada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = 5;
            usuario.Nome = "Nome do Usuário";
            usuario.Cidade = "Maceió";

            this.View(usuario);
        }

    }
}
