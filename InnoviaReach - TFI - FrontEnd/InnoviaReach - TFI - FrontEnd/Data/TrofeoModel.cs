﻿namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class TrofeoModel
    {
        public int Trofeo_ID { get; set; }
        public string Descripcion { get; set; }
        public string User_ID { get; set; }
        public int Videojuego_ID { get; set; }
        public Users usuario { get; set; }
        public VideojuegoModel videojuego { get; set; }
    }
}