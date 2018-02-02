using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimerScript : MonoBehaviour {

    public GameObject rabbit;
    //public Image rabbit;

    public GameObject EndPoint;
    //public Image spike;

    private Vector3 StartPos;
    private Vector3 EndPos;

    private Button BTStart;


    // w ile sekund ma sie przemiescic z pkt A do B
    public float LerpTime;

    private float CurrentLerpTime = 0;   //updateuje LerpTime

    private bool KeyHit = false;


        private void Start()
    {
        StartPos = rabbit.transform.position;
        EndPos = EndPoint.transform.position;
    }


    public void onStartButtonClick()
    {
        if (KeyHit == false) { 
        KeyHit = true;
        }
    }


    private void Update()
    {
        if(KeyHit == true)
        {
            CurrentLerpTime = CurrentLerpTime + Time.deltaTime;
           // if(CurrentLerpTime > LerpTime)
            //{
             //   CurrentLerpTime = LerpTime;
           // }

            float Perc = CurrentLerpTime / LerpTime;
            rabbit.transform.position = Vector3.Lerp(StartPos, EndPos, Perc);
        }
    }

  
    }

