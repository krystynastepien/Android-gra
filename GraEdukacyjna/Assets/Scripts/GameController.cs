using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour {

    public TextMeshProUGUI mathText;
    public TextMeshProUGUI resultTekst;

    private int leftNumber;
    private int rightNumber;
    private int mathOperator;
    private int trueResult;
    private int falseResult;


    public void Start()
    {
        createMath();
    }
    public void createMath()
    {
        leftNumber = Random.Range(0, 9);
        rightNumber = Random.Range(0, 9);

        mathOperator = Random.Range(0,3);

        switch (mathOperator)
        {
            case 0:
                trueResult = leftNumber + rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<TextMeshProUGUI>().text = leftNumber.ToString() + "+" + rightNumber.ToString();
                resultTekst.GetComponent<TextMeshProUGUI>().text = falseResult.ToString();
                break; //+
            case 1:
                trueResult = leftNumber - rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<TextMeshProUGUI>().text = leftNumber.ToString() + "-" + rightNumber.ToString();
                resultTekst.GetComponent<TextMeshProUGUI>().text = falseResult.ToString();
                break; //-
            case 2:
                trueResult = leftNumber * rightNumber;
                falseResult = trueResult + Random.Range(-2, 3);
                mathText.GetComponent<TextMeshProUGUI>().text = leftNumber.ToString() + "*" + rightNumber.ToString();
                resultTekst.GetComponent<TextMeshProUGUI>().text = falseResult.ToString();
                break; //*
        }
    }

	public void onTrueButtonClick()
    {
        if (trueResult == falseResult)
        {
            createMath();
        }
        else
        {

        }
    }

    public void onFalseButtonClick()
    {
        if(trueResult != falseResult)
        {
            createMath();
        }
        else
        {

        }
    }
}
