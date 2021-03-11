﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts.UI
{
    public class CoinPoints : MonoBehaviour
    {
    
            int pointCoins,recordPointCoins;
            Text pointCoinsTxt;
            void Start()
            {
                pointCoinsTxt = GameObject.FindWithTag("coinIUI").GetComponent<Text>();
                recordPointCoins = PlayerPrefs.GetInt("COINSRECORD");
            }

            void Update()
            {
                
            }
            public void AddPoints()
            {
                pointCoins +=1;
                pointCoinsTxt.text = pointCoins.ToString();
                SavePointsCoins();
            }

            void OnTriggerEnter2D(Collider2D other)
            {
                if(other.gameObject.CompareTag("Player"))
                {
                    AddPoints();
                }
            }

            void SavePointsCoins()
            {
                if(pointCoins>recordPointCoins)
                {
                    recordPointCoins = pointCoins;
                    PlayerPrefs.SetInt("COINSRECORD",recordPointCoins);
                }
            }
    }

}