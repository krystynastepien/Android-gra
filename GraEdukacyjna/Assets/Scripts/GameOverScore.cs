using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScore : MonoBehaviour
{

    public Text currentScoreKrolikText;
    public Text highScoreKrolikText;

    public void Start()
    {

        currentScoreKrolikText.GetComponent<Text>().text = "SCORE " + GameValues.currentScore.ToString();
        highScoreKrolikText.GetComponent<Text>().text = "HIGH SCORE " + PlayerPrefs.GetInt("HIGH_SCORE4", 0).ToString();

    }

}
