using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
    public void StartGame()
    {
        //SceneManager.LoadScene("Play");
        Application.LoadLevel("Play");
    }
}
