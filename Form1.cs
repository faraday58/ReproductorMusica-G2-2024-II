using System;
using System.Collections;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_II
{
    public partial class FormReproductor : Form
    {
        //Ejemplo
        private ArrayList canciones;

        public FormReproductor()
        {
            InitializeComponent();
            canciones = new ArrayList();
        }
        #region Métodos
        // Canciones agregadas por hardCode
        private void CancionesDefault()
        {
            canciones.Add(new Cancion("My demons", "Starset", "Transmissions"));
            canciones.Add(new Cancion("Time is running out", "Muse", "Absolution"));
            canciones.Add(new Cancion("Keep driving", "Harry Styles", "Harrys House"));
            canciones.Add(new Cancion("Presidente Maynez", "Yuawi", "Presidente Maynez"));
        }

        internal void AgregarCancion(Cancion cancion)
        {
            canciones.Add(cancion);
            lstbCanciones.Items.Add(cancion.Titulo);

        }

        #endregion


        #region Manejadores de Eventos
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancionesDefault();
            foreach (var cancion in canciones)
            {
                Cancion miCancion = (Cancion)cancion;
                lstbCanciones.Items.Add( miCancion.Titulo);
            }

        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cancion miCancion = (Cancion)canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = miCancion.Titulo;
            lbArtista.Text = miCancion.Artista;
            lbAlbum.Text = miCancion.Album;
        }

        private void agregarCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCancion formAgregar = new FormAgregarCancion();
            formAgregar.EnviarCancion += AgregarCancion;            
            formAgregar.ShowDialog();

        }
        #endregion
    }
}
