

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Carreras
{
    public struct Posicion
    {
        public float x;
        public float y;
        public Posicion(float x, float y)
        {
            this.x = x;
            this.y = y; 
        }
    }

    public class Controlador
    {
        public static Color[] colores = new Color[3] { Color.Red, Color.Blue, Color.Black };
        Auto[] autos = new Auto[3];
        Escenario escenario ; 
        Camara camara;
        Circuito circuito;

        static bool inicioCarrera;
        static bool finCarrera;
        static int ganador = -1;

        public static int Ganador
        {
            get { return Controlador.ganador; }
            set { Controlador.ganador = value; }
        }
        
        public static bool FinCarrera
        {
            get { return Controlador.finCarrera; }
            set { Controlador.finCarrera = value; }
        }

        public static bool InicioCarrera
        {
            get { return Controlador.inicioCarrera; }
            set { Controlador.inicioCarrera = value; }
        }

        public Controlador()
        {
            
            camara = new Camara();
            
        }

        public Camara Camara
        {
            get { return camara; }
        }

        public int ObtenerPrimerLugar()
        {
            float menor = autos[0].DistanciaRecorrida;
            int lugar = 0;
            for (int i = 1; i < autos.Length; i++)
            {
                if (menor > autos[i].DistanciaRecorrida)
                {
                    lugar = i;
                    menor = autos[i].DistanciaRecorrida;   
                }
            }
            return lugar; 
        }

        

        public float ObtenerDistanciaEnMetros(int carro)
        {
            return autos[carro].DistanciaRecorrida * -10; 
        }

        public void IniciarCarrera()
        {
            inicioCarrera = false;
            finCarrera = false; 
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i].Reiniciar(); 
            }
        }

        public void CrearObjetos()
        {
            escenario = new Escenario();
            circuito = new Circuito(); 
            float x = 0;
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new Auto(colores[i], x);
                x += 1.5f; 
            }
             
        }

        public void DibujarEscena()
        {
            escenario.Dibujar();
            circuito.Dibujar();
  
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i].Dibujar();
            }
        }
    }
}
