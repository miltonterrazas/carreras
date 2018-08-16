using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.OpenGL;
using ShadowEngine.ContentLoading; 


namespace Carreras
{
    public partial class FrmVista : Form
    {
        uint hdc;
        int camaraSeleccionada = 1;
        int contador;
        Controlador control ; 
        int ganadorMostrado = 0;
        int enMovimiento;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        int reproduciendo = 0;   

        public FrmVista()
        {
            InitializeComponent();
            control=new Controlador();
            //identificador del lugar en donde voy a dibujar
            hdc = (uint)this.Handle;
            //toma el error que sucedio
            string error = "";
            //Comando de inicializacion de la ventana grafica
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);

            //inicia la posicion de la camara asi como define en angulo de perspectiva,etc etc
            control.Camara.EstablecerPerspectiva();
            if (error != "")
            {
                MessageBox.Show("Ocurrio un error al inicializar openGL");
                this.Close();   
            }

            //Habilita las luces
            
            //float[] lightAmbient = { 0.15F, 0.15F, 0.15F, 0.0F };

            //Lighting.LightAmbient = lightAmbient; 
            
            Lighting.SetupLighting();  // encapsulado en el sahdow engine 
            
            ContentManager.SetTextureList("texturas\\");
            ContentManager.LoadTextures();
            ContentManager.SetModelList("modelos\\");
            ContentManager.LoadModels();  
            control.CrearObjetos();

            //Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);  

            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
            wplayer.URL = "sonidos/car_drift.mp3";
            wplayer.controls.stop();
        }

        public void ActualizarEstadoCarrera()
        {

            switch (enMovimiento)
            {
                case 1:
                    Gl.glTranslatef(0, 0, 0.35f);
                    break;
                case 2:
                    Gl.glTranslatef(0, 0, -0.35f);
                    break;
                case 3:
                    Gl.glTranslatef(-0.35f, 0, 0);
                    break;
                case 4:
                    Gl.glTranslatef(0.35f, 0, 0);
                    break;
            }
            
            contador++;
            if (Controlador.FinCarrera == true && ganadorMostrado == 0)
            {
                ganadorMostrado = 1;
                enMovimiento = 0;
                MessageBox.Show("El ganador es: " + lblPrimero.Text);
            }

            if (contador == 10)
            {
                if (Controlador.InicioCarrera == true && ganadorMostrado == 0)
                {
                    int primero = control.ObtenerPrimerLugar();
                    float distanciaRecorrida = control.ObtenerDistanciaEnMetros(primero);
                    lblDistancia.Text = Convert.ToString((int)distanciaRecorrida);
                    lblPrimero.Text = Controlador.colores[primero].Name;
                    lblPrimero.ForeColor = Controlador.colores[primero];
                    
                }
                contador = 0;
            }
        }


        private void tmrPaint_Tick(object sender, EventArgs e)
        {
            ActualizarEstadoCarrera(); 
           
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
          
            control.DibujarEscena();
           
            Utils.SwapBuffers(hdc);
           
            Gl.glFlush(); 
        }

       
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, this.Width, this.Height);
            //select the projection matrix
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //la reseteo
            Gl.glLoadIdentity();
            //45 = angulo de vision
            //1  = proporcion de alto por ancho
            //0.1f = distancia minima en la que se pinta
            //1000 = distancia maxima
            Glu.gluPerspective(55, this.Width/(float)this.Height  , 0.1f, 1000);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            control.Camara.SeleccionarCamara(camaraSeleccionada - 1); 
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                enMovimiento = 1;
                ReproducirSonido();
            }
            if (e.KeyValue == 40)
            {
                enMovimiento = 2;
            }
            if (e.KeyValue == 37)
            {
                enMovimiento = 3;
            }
            if (e.KeyValue == 39)
            {
                enMovimiento = 4;
            }

        }

        private void ReproducirSonido()
        {
            if (reproduciendo == 0)
            {
                wplayer.controls.play();
                reproduciendo = 1;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            enMovimiento = 0;
        }

        private void camara1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.Camara.SeleccionarCamara(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)); 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controlador.InicioCarrera = true;   
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lblPrimero.Text = "Ninguno";
            lblDistancia.Text = "0";
            control.IniciarCarrera();
            ganadorMostrado = 0;
            contador = 0;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        void wplayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                reproduciendo = 0;

            }
        }
             
        
    }
}
