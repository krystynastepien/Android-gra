using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraDzialaniaScript : MonoBehaviour
{
    public GameObject rabbit;

    private int Wyswietl;
    private int porownaj;

    public Text mathText;
    public Text resultText;
    public Text scoreText;

    private int leftNumber; //lewy przycisk
    private int rightNumber; //prawy przycisk
    private int mathOperator; //znak operacji wykonywanej
    private int trueResult;
    private int falseResult;
    private int falseResult2;
    private int falseResult3;
    private int currentScore; //punkty
    private int HiScore;

    public void Start()
    {
        currentScore = 0;
        createMath();
    }

    public void Update()
    {
    }

    public void createMath()
    {
        leftNumber = Random.Range(0, 9);
        rightNumber = Random.Range(0, 9);

        mathOperator = Random.Range(0, 3);

        switch (mathOperator)
        {

            case 0:
                trueResult = leftNumber - rightNumber;
                falseResult = trueResult + Random.Range(-4, 4);
                falseResult2 = trueResult + Random.Range(-4, 4);
                falseResult3 = trueResult + Random.Range(-4, 4);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "-" + rightNumber.ToString();
                int[] wynik2 = { trueResult, falseResult2, falseResult3 };
                Wyswietl = Random.RandomRange(0, 2);
                resultText.GetComponent<Text>().text = wynik2[Wyswietl].ToString();
                porownaj = wynik2[Wyswietl];
                break; //-

            case 1:
                trueResult = leftNumber + rightNumber;
                falseResult = trueResult + Random.Range(-4, 4);
                falseResult2 = trueResult + Random.Range(-4, 4);
                falseResult3 = trueResult + Random.Range(-4, 4);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "+" + rightNumber.ToString();
                int[] wynik = { trueResult, falseResult2, falseResult3 };
                Wyswietl = Random.RandomRange(0, 2);
                resultText.GetComponent<Text>().text = wynik[Wyswietl].ToString();
                porownaj = wynik[Wyswietl];
                break; //+

            case 2:
                trueResult = leftNumber * rightNumber;
                falseResult = trueResult + Random.Range(-4, 4);
                falseResult2 = trueResult + Random.Range(-4, 4);
                falseResult3 = trueResult + Random.Range(-4, 4);
                mathText.GetComponent<Text>().text = leftNumber.ToString() + "*" + rightNumber.ToString();
                int[] wynik3 = { trueResult, falseResult2, falseResult3 };
                Wyswietl = Random.RandomRange(0, 2);
                resultText.GetComponent<Text>().text = wynik3[Wyswietl].ToString();
                porownaj = wynik3[Wyswietl];
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
        if (trueResult == porownaj)
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
        if (trueResult != porownaj)
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
