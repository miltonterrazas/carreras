
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ShadowEngine;
using Tao.OpenGl; 
using System.Windows.Forms;  
using ShadowEngine.ContentLoading; 

namespace Carreras
{
    class Auto
    {
        float anguloLLanta;
        Color color;
        Posicion pos;
        float velocidad;
        float distanciaRecorrida = 0;
        static Random randomizer = new Random(); 
        int contador;
        ModelContainer contenedorModelo;
        
        List<Mesh> llantas = new List<Mesh>();
        Mesh chasis;
        
        int textura;


        public float DistanciaRecorrida
        {
            get { return distanciaRecorrida; }
        }

        public Auto(Color c,float posX)
        {
           color = c;
           pos = new Posicion(posX, 10);  
           velocidad = 0.2f + (float)randomizer.NextDouble() / 18f;
           Crear();
        }

        public void Reiniciar()
        {
            distanciaRecorrida = 0;
        }

        public void Crear()
        {
            contenedorModelo = ContentManager.GetModelByName("carro.3DS");
            contenedorModelo.CreateDisplayList(); 
            
            contenedorModelo.ScaleX = 0.1f;
            contenedorModelo.ScaleY = 0.1f;
            contenedorModelo.ScaleZ = 0.1f;

            foreach (var item in contenedorModelo.GetMeshes)
            {
                item.CalcCenterPoint();
                switch (item.Name)
                {
                    case "rim":
                        llantas.Add(item);
                        break; 
                    case "body":
                         chasis = item;
                         break;
                } 
            }

            textura = ContentManager.GetTextureByName("chasis"+color.Name+".jpg");   
          
        }

        public void Dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(pos.x, 0, pos.y);

            #region Control

            if (Controlador.InicioCarrera == true)
            {
                
                Gl.glTranslatef(0, 0, distanciaRecorrida); 
                if (distanciaRecorrida > -59)
                {
                    anguloLLanta -= 24;
                    distanciaRecorrida -= velocidad;
                }
                else
                    if (Controlador.FinCarrera == false)
                    {
                        Controlador.FinCarrera = true;
                    }
                contador++;
                // cambio velocidad
                if (contador == 30)
                {
                    contador = 0;
                    velocidad = 0.2f + (float)randomizer.NextDouble() / 20f;
                }
            }

            #endregion

            contenedorModelo.DrawWithTextures(); 

            #region chasis

            Gl.glPushMatrix();
            Gl.glScalef(0.1f, 0.1f, 0.1f);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textura);
            chasis.Draw();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix(); 

            #endregion

            #region Llantas

            foreach (var item in llantas)
            {
                Gl.glColor3f(0.5f, 0.5f, 0.5f);//especifico el color de la rueda
                Gl.glPushMatrix();
                Gl.glScalef(0.1f, 0.1f, 0.1f);
                Gl.glTranslatef(item.CenterPoint.X, item.CenterPoint.Y, item.CenterPoint.Z); //traslada a la posicion original 
                Gl.glRotatef(anguloLLanta, 1, 0, 0);// se rota 
                Gl.glTranslatef(-item.CenterPoint.X, -item.CenterPoint.Y, -item.CenterPoint.Z); // traslado al centro
                item.Draw();  // dibujo la rueda 
                Gl.glPopMatrix();
                Gl.glColor3f(1, 1, 1); 
            }

            #endregion

            Gl.glPopMatrix();
        }
    }
}
