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
    private int falseMnozResult2;
    private int falseMnozResult3;
    private int currentMnozScore; //punkty
    private int MnozHiScore;
    private int Wyswietl;
    private int porownaj;

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
                falseMnozResult = trueMnozResult + Random.Range(-4, 4);
                falseMnozResult2 = trueMnozResult + Random.Range(-4, 4);
                falseMnozResult3 = trueMnozResult + Random.Range(-4, 4);
                mathMnozText.GetComponent<Text>().text = leftMnozNumber.ToString() + "*" + rightMnozNumber.ToString();
                int[] wynik = { trueMnozResult, falseMnozResult2, falseMnozResult3 };
                Wyswietl = Random.RandomRange(0, 2);
                resultMnozText.GetComponent<Text>().text = wynik[Wyswietl].ToString();
                porownaj = wynik[Wyswietl];
                break; //+
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
        if (trueMnozResult == porownaj)
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
        if (trueMnozResult != porownaj)
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
