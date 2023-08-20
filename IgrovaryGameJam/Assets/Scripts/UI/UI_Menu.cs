using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Menu : MonoBehaviour
{
    public GameObject load;

    public void Scene(int numberScene) {
        SceneManager.LoadScene(numberScene);
    }
    
    public void Exit () {
        Application.Quit();
    }
    
    public void OpnenURL(string URL){
        Application.OpenURL(URL);
    }
}
