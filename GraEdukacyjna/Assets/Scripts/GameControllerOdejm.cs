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
    private int currentOdejmScore; //punkty
    private int OdejmHiScore;


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
                falseOdejmResult = trueOdejmResult + Random.Range(-2, 3);
                mathOdejmText.GetComponent<Text>().text = leftOdejmNumber.ToString() + "-" + rightOdejmNumber.ToString();
                resultOdejmText.GetComponent<Text>().text = falseOdejmResult.ToString();
                break; //-
            
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
        if (trueOdejmResult == falseOdejmResult)
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
        if(trueOdejmResult != falseOdejmResult)
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
