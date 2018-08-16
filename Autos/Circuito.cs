
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl;  

namespace Carreras
{
    class Circuito
    {
        int initList;

        public Circuito()
        {
            Crear();
        }

        public void Crear()
        { 
            initList = Gl.glGenLists(1);
            Gl.glNewList(initList, Gl.GL_COMPILE);

            int texturaDelimitador = ContentManager.GetTextureByName("poste.jpg");
            int texturaSalida = ContentManager.GetTextureByName("salida.jpg");

            //Linea de partida
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaDelimitador);
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, 8);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 0.1f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 0.1f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.75f, 0.1f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.75f, 0.1f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 2f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.75f, 2f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 0.1f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2f, 0f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.75f, 2f, 0);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.75f, 0.1f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.75f, 0.1f, 0.5f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.75f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-0.75f, 2f, 0.0f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-0.75f, 0.1f, 0.0f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-1f, 2f, 0.0f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-1f, 0.1f, 0.0f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(3.75f, 0.1f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(3.75f, 0.1f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4.0f, 0.1f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4.0f, 0.1f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(3.75f, 2f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(3.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4.0f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4.0f, 2f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(3.75f, 0.1f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(3.75f, 2f, 0f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4.0f, 2f, 0);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4.0f, 0.1f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(3.75f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(3.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4.0f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4.0f, 0.1f, 0.5f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(4.0f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(4.0f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4.0f, 2f, 0.0f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4.0f, 0.1f, 0.0f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(3.75f, 0.1f, 0.5f);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(3.75f, 2f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.75f, 2f, 0.0f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.75f, 0.1f, 0.0f);
            Gl.glEnd();

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaSalida);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2.5f, 0);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4f, 2.5f, 0f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4f, 2f, 0f);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 2f, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-1f, 2.5f, 0.5f);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4f, 2.5f, 0.5f);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4f, 2f, 0.5f);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-1f, 2f, 0.5f);
            Gl.glEnd();

            Gl.glPopMatrix();

            //Linea llegada
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, -50);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, 0.05f, 0);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.5f, 0.05f, 1);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.5f, 0.05f, 0);
            Gl.glEnd();
            Gl.glPopMatrix();


            //No puede ser fija, debe ser variable...Esto esta fijo

            int texturaAsfalto = ContentManager.GetTextureByName("asfalto.jpg");
            int texturaAsfaltoh = ContentManager.GetTextureByName("asfaltoh.jpg");
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaAsfaltoh);
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, -100);
           
            //Hacer una lectura del archivo y dibujarlo.....

            float x = -0.8f;
            for (int i = 0; i < 2; i++)
            {
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(x, 0, -4.6f);
                Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(x, 0, 0);
                Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(x - 10, 0, 0);
                Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(x - 10, 0, -4.6f);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(x, 0, 4.6f+210);
                Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(x, 0, 210);
                Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(x - 10, 0, 210);
                Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(x - 10, 0, 4.6f+210);
                Gl.glEnd();
                x -= 10;
            }

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaAsfalto);
            int count = 0;
            for (int y = 0; y < 21; y++)
            {
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.8f, 0, count);
                Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.8f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.8f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.8f, 0, count);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-25.8f, 0, count);
                Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-25.8f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(-21.2f, 0, count + 10);
                Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(-21.2f, 0, count);
                Gl.glEnd();
                count += 10; 
            }

            Gl.glPopMatrix();

            Gl.glEndList(); 
        }

        public void Dibujar()
        {
            Gl.glCallList(initList);  
        }
    }
}
