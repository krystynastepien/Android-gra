using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

    public void quit_app()
    {
        Debug.Log("Has quit game");
        Application.Quit();
    }
}
