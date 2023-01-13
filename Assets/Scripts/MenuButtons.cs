using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
  
   public void PLayGame()
   {
      SceneManager.LoadScene("LevelScreen");
   }

   public void QuitGame()
   {
      Application.Quit();
   }
}
