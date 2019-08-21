using System;

namespace CoreEscuela.Entidades
{
    public abstract class objetoEscuelaBase
    {
        public string Nombre { get; set; }
        public string UniqueId { get; set; } 

        public objetoEscuelaBase()
        {
            UniqueId =  Guid.NewGuid().ToString();
        }
    }
}