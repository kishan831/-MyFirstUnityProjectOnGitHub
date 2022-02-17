using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{   

    public void playgame() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void playgame1() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void playgame2() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }


    public void Back() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      
    }
    public void Back1() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
      
    }
    public void Back2() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
      
    }
 

}
