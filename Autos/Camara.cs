

using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl; 

namespace Carreras
{
    public class Camara
    {
        public void SeleccionarCamara(int camara)
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            switch (camara)
            {
                case 0:
                    {
                        Glu.gluLookAt(2, 3, 14, 2, 0, 5, 0, 1, 0);
                        break;
                    }
                case 1:
                    {
                        Glu.gluLookAt(-2, 7, 10, 1, 3, 1, 0, 1, 0);
                        break;
                    }
                case 2:
                    {
                        Glu.gluLookAt(0, 95, 0, 0, 0, 1, 0, 1, 0);
                        break;
                    }
                case 3:
                    {
                        Glu.gluLookAt(3, 3, -47, 1, 0, 1, 0, 1, 0);
                        break;
                    }
            }
        }

        public void EstablecerPerspectiva()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            //55 = Angulo de Vision
            //1  = aspect ratio proporcion veritcal/horizontal
            //0.1f = distancia minima
            //1000 = distancia maxima
            Glu.gluPerspective(55, 1, 0.1f, 1000);
            SeleccionarCamara(0);
        }
    }
}
