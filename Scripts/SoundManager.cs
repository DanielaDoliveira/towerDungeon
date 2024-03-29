﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.PlayerEnumerators;
namespace Scripts
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        public AudioSource musicTheme, musicMenu;
        //public AudioClip musicIntro;
          public AudioSource soundFX,chestFx;
          public AudioClip coinsFx;
       


        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(instance);
        }

        void Start()
        {

        }

        public void PlayMusicTheme()
        {
            musicTheme.Play();
        }
        public void StopMusicMenu()
        {
            musicMenu.Stop();
        }
        public void StopMusicTheme()
        {
            musicTheme.Stop();
        }
        public void PlayMusicMenu()
        {
            musicMenu.Play();
        }

        public void PlayAttackFx(AudioSource soundEffects)
        {
            soundFX = soundEffects;
            soundEffects.Play();
        }
        void Update()
        {
           
        }
        public void PlayChestOpenFx(AudioSource soundEffects)
        {
            soundEffects = chestFx;
            soundEffects.Play();
        }
        public void PlayGetCoinsFx()
        {
           
            soundFX.PlayOneShot(coinsFx);
        }
        
      
        
    }

}
