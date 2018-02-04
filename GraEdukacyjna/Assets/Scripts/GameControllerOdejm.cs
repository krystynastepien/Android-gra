using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControllerOdejm : MonoBehaviour
{

    
    public Text mathOdejmText;
    public Text resultOdejmText;
    public Text scoreOdejmText;

    private int leftOdejmNumber; //lewy przycisk
    private int rightOdejmNumber; //prawy przycisk
    private int mathOdejmOperator; //znak operacji wykonywanej
    private int trueOdejmResult;
    private int falseOdejmResult;
    private int falseOdejmResult2;
    private int falseOdejmResult3;
    private int currentOdejmScore; //punkty
    private int OdejmHiScore;
    private int Wyswietl;
    private int porownaj;


    public void Start()
    {
        currentOdejmScore = 0;
        createOdejmMath();
    }
    public void createOdejmMath()
    {
        leftOdejmNumber = Random.Range(0, 9);
        rightOdejmNumber = Random.Range(0, 9);

        mathOdejmOperator = Random.Range(0, 1);

        switch (mathOdejmOperator)
        {

            case 0:
                trueOdejmResult = leftOdejmNumber - rightOdejmNumber;
                falseOdejmResult = trueOdejmResult + Random.Range(-4, 4);
                falseOdejmResult2 = trueOdejmResult + Random.Range(-4, 4);
                falseOdejmResult3 = trueOdejmResult + Random.Range(-4, 4);
                mathOdejmText.GetComponent<Text>().text = leftOdejmNumber.ToString() + "-" + rightOdejmNumber.ToString();
                int[] wynik = { trueOdejmResult, falseOdejmResult2, falseOdejmResult3 };
                Wyswietl = Random.RandomRange(0, 2);
                resultOdejmText.GetComponent<Text>().text = wynik[Wyswietl].ToString();
                porownaj = wynik[Wyswietl];
                break; //+
        }

                scoreOdejmText.GetComponent<Text>().text = currentOdejmScore.ToString();
    }

    public void LoseGameOdejm()
    {
        GameValues.currentScore = currentOdejmScore;
        int highScoreOdejm = PlayerPrefs.GetInt("HIGH_SCORE2", 0);
        if (currentOdejmScore > highScoreOdejm)
        {
            PlayerPrefs.SetInt("HIGH_SCORE2", currentOdejmScore);
        }
        Application.LoadLevel("LoseGameOdejm");

    }

    public void onTrueOdejmButtonClick()
    {
        if (trueOdejmResult == porownaj)
        {
            currentOdejmScore += 1;
            createOdejmMath();
        }
        else
        {

            LoseGameOdejm();
        }
    }
    public void onFalseOdejmButtonClick()
    {
        if(trueOdejmResult != porownaj)
        {
            currentOdejmScore += 1;
            createOdejmMath();
        }
        else
        {
            LoseGameOdejm();
        }
    }
    
    
}
