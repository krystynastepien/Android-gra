using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMainMenuScene : MonoBehaviour {

    public void Open_Scene_MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
