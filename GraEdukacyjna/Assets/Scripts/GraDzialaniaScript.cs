using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraDzialaniaScript : MonoBehaviour
{


    public Text mathText;
    public Text resultText;
    public Text scoreText;

    private int leftNumber; //lewy przycisk
    private int rightNumber; //prawy przycisk
    private int mathOperator; //znak operacji wykonywanej
    private int trueResult;
    private int falseResult;
    private int currentScore; //punkty
    private int HiScore;


    public void Start()
    {
        currentScore = 0;
        createMath();
    }
    public void createMath()
    {
        leftNumber = Random.Range(0, 9);
        rightNumber = Random.Range(0, 9);

        mathOperator = Random.Range(0, 3);

        switch (mathOperator)
        {

            case 0:
                trueResult = leftNumber * rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "*" + rightNumber.ToString();
                resultText.GetComponent<Text>().text = falseResult.ToString();
                break; //*

            case 1:
                trueResult = leftNumber + rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "+" + rightNumber.ToString();
                resultText.GetComponent<Text>().text = falseResult.ToString();
                break; //*

            case 2:
                trueResult = leftNumber - rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "-" + rightNumber.ToString();
                resultText.GetComponent<Text>().text = falseResult.ToString();
                break; //*
        }

        scoreText.GetComponent<Text>().text = currentScore.ToString();
    }

    public void LoseGame()
    {
        GameValues.currentScore = currentScore;
        int highScore = PlayerPrefs.GetInt("HIGH_SCORE3", 0);
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HIGH_SCORE3", currentScore);
        }
        Application.LoadLevel("GameOver");

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
        if (trueResult != falseResult)
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
