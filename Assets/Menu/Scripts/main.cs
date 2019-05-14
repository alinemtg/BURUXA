using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    
    public void PlayGame () {
        SceneManager.LoadScene("BonusScene");

    }
    public void PlayGame2 () {
        SceneManager.LoadScene("Main");

    }
     public void About () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }

    public void Game1forMenu () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

    }
      public void Game1forMenu2 () {
        SceneManager.LoadScene("Menu");

    }

          public void Storie () {
        SceneManager.LoadScene("Storie");

    }

 //   public void QuitGame () {
     // Debug.lod("Quit");
       // Application.Quit();
   // }
}
