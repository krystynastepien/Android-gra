using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseGameOdejm : MonoBehaviour
{

    public Text currentScoreOdejmText;
    public Text highScoreOdejmText;

    public void Start()
    {

        currentScoreOdejmText.GetComponent<Text>().text = "SCORE " + GameValues.currentScore.ToString();
        highScoreOdejmText.GetComponent<Text>().text = "HIGH SCORE " + PlayerPrefs.GetInt("HIGH_SCORE2", 0).ToString();

    }

    public void onPlayAgainOdejmButtonClick()
    {

        Application.LoadLevel("Odejmowanie");



    }

    public void onMenuButtonClick()
    {

    }


}
