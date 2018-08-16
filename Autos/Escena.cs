using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Carreras
{
    public class Escena
    {
        Hashtable objetos=new Hashtable();

        public void AdicionarObjeto(String nombre,Dibujable obj)
        {
            objetos.Add(nombre, obj);
        }

        public void QuitarObjeto(String nombre)
        {
            objetos.Remove(nombre);     
        }

        public Dibujable ObtenerObjeto(String nombre)
        {
            return (Dibujable)objetos[nombre];
        }

        public void Dibujar()
        {
            foreach (string nombre in objetos.Keys)
            {
              ((Dibujable)(objetos[nombre])).Dibujar();
            }
        }

    }
}
