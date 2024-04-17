using System;

namespace ReproductorMusica_G2_2024_II
{
    internal class Cancion
    {
        #region Atributos
        private string titulo;
        private string artista;
        private string album;
        #endregion
        #region Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        #endregion


        #region Constructor
        public Cancion(string titulo, string artista, string album)
        {
            Titulo = titulo;
            Artista = artista;
            Album = album;
        }
        #endregion

        
    }
}
