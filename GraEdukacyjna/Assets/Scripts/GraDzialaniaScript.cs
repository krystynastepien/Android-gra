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
    private int currentKrolikScore; //punkty
    private int HiScore;


    public void Start()
    {
        currentKrolikScore = 0;
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

        scoreText.GetComponent<Text>().text = currentKrolikScore.ToString();
    }

    public void LoseGameKrolik()
    {
        GameValues.currentScore = currentKrolikScore;
        int highScoreKrolik = PlayerPrefs.GetInt("HIGH_SCORE4", 0);
        if (currentKrolikScore > highScoreKrolik)
        {
            PlayerPrefs.SetInt("HIGH_SCORE4", currentKrolikScore);
        }
        Application.LoadLevel("GameOver");

    }

    public void onTrueButtonClick()
    {
        if (trueResult == falseResult)
        {
            currentKrolikScore += 1;
            createMath();
        }
        else
        {

            LoseGameKrolik();
        }
    }
    public void onFalseButtonClick()
    {
        if (trueResult != falseResult)
        {
            currentKrolikScore += 1;
            createMath();
        }
        else
        {
            LoseGameKrolik();
        }
    }


}
