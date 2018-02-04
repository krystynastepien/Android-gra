using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScore : MonoBehaviour
{

    public Text currentScoreText;
    public Text highScoreText;

    public void Start()
    {

        currentScoreText.GetComponent<Text>().text = "SCORE " + GameValues.currentScore.ToString();
        highScoreText.GetComponent<Text>().text = "HIGH SCORE " + PlayerPrefs.GetInt("HIGH_SCORE", 0).ToString();

    }

}
