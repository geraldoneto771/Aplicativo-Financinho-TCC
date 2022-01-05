using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class AudioManager : MonoBehaviour
{

    public AudioSource[] _audio = new AudioSource[1];
    int som = 0;
    //public AudioSource _audio1;
    // Start is called before the first frame update
    

  /* public void Som()
    {
        
        if (som == 0)
        {
            _audio[0].Pause();

            print("audio desligado");
            som = 1;
         
            
        } else
        {
            _audio[0].Play();

            print("audio ligado");
            som = 0;
           
            
        }
        
    }
  */

    public void SomAtivar()
    {
        _audio[0].Play();

        print("audio desligado");
        
    }
    public void SomDesativar()
    {
        _audio[0].Pause();

        print("audio ligado");
    }
   
}
