using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour {

    public TextMeshProUGUI mathText; //okienko dla dzialania
    public TextMeshProUGUI resultTekst; //okienko dla wyniku
    public Text scoreText; //okienko dla punktow

    private int leftNumber; //lewy przycisk
    private int rightNumber; //prawy przycisk
    private int mathOperator; //znak operacji wykonywanej
    private int trueResult; 
    private int falseResult;
    private int currentScore; //punkty


    public void Start()
    {
        currentScore = 0;
        createMath();
    }
    public void createMath()
    {
        leftNumber = Random.Range(0, 9);
        rightNumber = Random.Range(0, 9);

        mathOperator = Random.Range(0,1);

        switch (mathOperator)
        {
            case 0:
                trueResult = leftNumber + rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<TextMeshProUGUI>().text = leftNumber.ToString() + "+" + rightNumber.ToString();
                resultTekst.GetComponent<TextMeshProUGUI>().text = falseResult.ToString();
                break; //+
            
        }

        scoreText.GetComponent<Text>().text = currentScore.ToString();
    }

    public void LoseGame()
    {
        GameValues.currentScore = currentScore;
        int highScore = PlayerPrefs.GetInt("HIGH_SCORE", 0);
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HIGH_SCORE", currentScore);
        }
        Application.LoadLevel("LoseGame");
           
    }

	public void onTrueButtonClick()
    {
        if (trueResult == falseResult)
        {
            currentScore += 1;
            createMath();
        }
        else
        {
            LoseGame();
        }
    }

    public void onFalseButtonClick()
    {
        if(trueResult != falseResult)
        {
            currentScore += 1;
            createMath();
        }
        else
        {
            LoseGame();
        }
    }
}
