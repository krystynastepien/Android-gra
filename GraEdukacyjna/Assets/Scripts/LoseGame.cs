using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseGame : MonoBehaviour {

    public Text currentScoreText;
    public Text highScoreText;
    
    public void Start()
    {
        currentScoreText.GetComponent<Text>().text ="SCORE "+ GameValues.currentScore.ToString();
        highScoreText.GetComponent<Text>().text = "HIGH SCORE "+ PlayerPrefs.GetInt("HIGH_SCORE", 0).ToString();

    }

	public void onPlayAgainButtonClick()
    {
        Application.LoadLevel("Dodawanie");
        
    }
		
    public void onMenuButtonClick()
    {

    }

	
}
