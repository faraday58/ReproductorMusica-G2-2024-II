using System;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_II
{
    public partial class FormAgregarCancion : Form
    {
        internal delegate void DelegateCancion(Cancion cancion);
        internal event DelegateCancion EnviarCancion;


        public FormAgregarCancion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnviarCancion(
                new Cancion(txtbTitulo.Text, 
                txtbArtista.Text, txtbAlbum.Text)); 


        }
    }
}
