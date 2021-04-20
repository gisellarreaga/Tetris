using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Declaracion de Variables
        //Lista para agregar 2 sonidos .wav
        List<System.Media.SoundPlayer> soundList = new List<System.Media.SoundPlayer>();
        //DispatcherTime
        DispatcherTimer timer;
        //Figuras Random
        Random shapeRandom;


        //Reproducir el sonido. Index = 0 va reproducir collided.wav y Index = 1 Reproducri Delete Line
        private void playSound(int index)
        {
            soundList[index].Play();
        }
    }



}