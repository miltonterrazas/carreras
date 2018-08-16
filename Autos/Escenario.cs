
using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl; 

namespace Carreras
{
    class Escenario
    {
        public void Dibujar()
        {
            int ancho = 240;        //
            int alto = 200;
            int largo = 240;

            //Coordenadas inicio
            int x = 10;                 //donde va a comenzar el auto
            int y = -3;
            int z = 7;

            //Centro del Escenario
            x = x - ancho / 2;
            y = y - alto / 2;
            z = z - largo / 2;

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("atras.jpg"));

            Gl.glBegin(Gl.GL_QUADS);                    //poligono, definiendo un cuadrado
            Gl.glNormal3d(-1, 1, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x + ancho, y, z);
            Gl.glNormal3d(-1, -1, 1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x + ancho, y + alto, z);
            Gl.glNormal3d(1, -1, 1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x, y + alto, z);
            Gl.glNormal3d(1, 1, 1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x, y, z);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("adelante.jpg"));
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3d(1, 1, -1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x, y, z + largo);
            Gl.glNormal3d(1, -1, -1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x, y + alto, z + largo);
            Gl.glNormal3d(-1, -1, -1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x + ancho, y + alto, z + largo);
            Gl.glNormal3d(-1, 1, -1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x + ancho, y, z + largo);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("arriba.jpg"));
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3d(-1, -1, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x + ancho, y + alto, z);
            Gl.glNormal3d(-1, -1, -1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x + ancho, y + alto, z + largo);
            Gl.glNormal3d(1, -1, -1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x, y + alto, z + largo);
            Gl.glNormal3d(1, -1, 1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x, y + alto, z);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("izquierda.jpg"));
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3d(1, -1, 1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x, y + alto, z);
            Gl.glNormal3d(1, -1, -1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x, y + alto, z + largo);
            Gl.glNormal3d(1, 1, -1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x, y, z + largo);
            Gl.glNormal3d(1, 1, 1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x, y, z);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("derecha.jpg"));
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3d(-1, 1, 1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x + ancho, y, z);
            Gl.glNormal3d(-1, 1, -1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x + ancho, y, z + largo);
            Gl.glNormal3d(-1, -1, -1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x + ancho, y + alto, z + largo);
            Gl.glNormal3d(-1, -1, 1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x + ancho, y + alto, z);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("cesped.jpg"));
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3d(1, 1, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x, -0.5f, z);
            Gl.glNormal3d(1, 1, -1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x, -0.5f, z + largo);
            Gl.glNormal3d(-1, 1, -1);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x + ancho, -0.5f, z + largo);
            Gl.glNormal3d(-1, 1, 1);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x + ancho, -0.5f, z);
            Gl.glEnd();
        }
    }
}
