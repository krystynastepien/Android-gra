using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControllerMnoz : MonoBehaviour
{


    public Text mathMnozText;
    public Text resultMnozText;
    public Text scoreMnozText;

    private int leftMnozNumber; //lewy przycisk
    private int rightMnozNumber; //prawy przycisk
    private int mathMnozOperator; //znak operacji wykonywanej
    private int trueMnozResult;
    private int falseMnozResult;
    private int currentMnozScore; //punkty
    private int MnozHiScore;


    public void Start()
    {
        currentMnozScore = 0;
        createMnozMath();
    }
    public void createMnozMath()
    {
        leftMnozNumber = Random.Range(0, 9);
        rightMnozNumber = Random.Range(0, 9);

        mathMnozOperator = Random.Range(0, 1);

        switch (mathMnozOperator)
        {

            case 0:
                trueMnozResult = leftMnozNumber * rightMnozNumber;
                falseMnozResult = trueMnozResult + Random.Range(-2, 3);
                mathMnozText.GetComponent<Text>().text = leftMnozNumber.ToString() + "*" + rightMnozNumber.ToString();
                resultMnozText.GetComponent<Text>().text = falseMnozResult.ToString();
                break; //*

        }

        scoreMnozText.GetComponent<Text>().text = currentMnozScore.ToString();
    }

    public void LoseGameMnoz()
    {
        GameValues.currentScore = currentMnozScore;
        int highScoreMnoz = PlayerPrefs.GetInt("HIGH_SCORE3", 0);
        if (currentMnozScore > highScoreMnoz)
        {
            PlayerPrefs.SetInt("HIGH_SCORE3", currentMnozScore);
        }
        Application.LoadLevel("LoseGameMnoz");

    }

    public void onTrueMnozButtonClick()
    {
        if (trueMnozResult == falseMnozResult)
        {
            currentMnozScore += 1;
            createMnozMath();
        }
        else
        {

            LoseGameMnoz();
        }
    }
    public void onFalseOdejmButtonClick()
    {
        if (trueMnozResult != falseMnozResult)
        {
            currentMnozScore += 1;
            createMnozMath();
        }
        else
        {
            LoseGameMnoz();
        }
    }


}
