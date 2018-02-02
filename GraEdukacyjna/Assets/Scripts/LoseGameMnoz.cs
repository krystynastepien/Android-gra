using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseGameMnoz : MonoBehaviour
{

    public Text currentScoreMnozText;
    public Text highScoreMnozText;

    public void Start()
    {
        
        currentScoreMnozText.GetComponent<Text>().text = "SCORE " + GameValues.currentScore.ToString();
        highScoreMnozText.GetComponent<Text>().text = "HIGH SCORE " + PlayerPrefs.GetInt("HIGH_SCORE3", 0).ToString();

    }

    public void onPlayAgainMnozButtonClick()
    {

        Application.LoadLevel("Mnozenie");



    }

    public void onMenuButtonClick()
    {

    }


}
