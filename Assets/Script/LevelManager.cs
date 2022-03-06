using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void RestartLevel(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   public void LoadLevel(){
       SceneManager.LoadScene(0);
   }
    public void MainMenu(){
       SceneManager.LoadScene(1);
   }
   public void QuitGame(){
       Application.Quit();
   }
}
