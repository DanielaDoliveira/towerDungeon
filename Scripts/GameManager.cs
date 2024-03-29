using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
using Scripts.WarriorScripts.PlayerEnumerators;
using UnityEngine.SceneManagement;

namespace Scripts
{
    public class GameManager : MonoBehaviour
{

      public GameObject warrior,archer;
      public GameState gameState;
      public static GameManager instance;
        private int id;

    private void Awake() {
      if(instance == null)
      {
        instance = this;
      }
      
      DontDestroyOnLoad(instance);
    }
    void Start()
    {

      
    }

   
    void Update()
    {
        
    }



     void InitializePlayer()
    {

      id = PlayerPrefs.GetInt("CHARACTER");
      warrior.SetActive(false);
      archer.SetActive(false);
      if(id == 1)
      {
           warrior.SetActive(true);
      }
      else if(id == 2)
      {
          archer.SetActive(true);        
      }
    }

   public void GameOver()
    {
      gameState = GameState.endGame;
      if(gameState == GameState.endGame)
      {
        Invoke("LoadGameOver",.1f);
       
      }
    }
   public void GameOverOptions()
    {
          
         SceneManager.LoadScene("introScene");
    
    }

    public void BackToGame()
    {
      
      SceneManager.LoadScene("game");
    }
    public void GameOn()
    {
         gameState = GameState.playing;
           InitializePlayer();
    }

    public void LoadGameOver()
    {
       PlayerPrefs.SetInt("COINPOINTS",0);
       SceneManager.LoadScene("GameOver");
       SoundManager.instance.StopMusicTheme();
    }
}

}
