using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame() 
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void ExitGame() 
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
