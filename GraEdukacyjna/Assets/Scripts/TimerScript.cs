using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimerScript : MonoBehaviour {

    public GameObject rabbit;
    //public Image rabbit;

    public GameObject spike;
    //public Image spike;

    private Vector3 StartPos;
    private Vector3 EndPos;

    private Button BTStart;


    // w ile sekund ma sie przemiescic z pkt A do B
    private float LerpTime = 3;

    private float CurrentLerpTime = 0;   //updateuje LerpTime

    private bool KeyHit = false;


    private void Start()
    {
        StartPos = rabbit.transform.position;
        EndPos = spike.transform.position;
        Button btn = BTStart.GetComponent<Button>();
    }


    public void onStartButtonClick()
    {
        KeyHit = true;
    }


    private void Update()
    {
        if(KeyHit == true)
        {
            CurrentLerpTime = CurrentLerpTime + Time.deltaTime;
            if(CurrentLerpTime >= LerpTime)
            {
                CurrentLerpTime = LerpTime;
            }

            float Perc = CurrentLerpTime / LerpTime;
            rabbit.transform.position = Vector3.Lerp(StartPos, EndPos, Perc);

           // if(rabbit.transform.position==spike.transform.position)
           // {
            //    SceneManager.LoadScene("GameOver");
           // }
        }
    }

    

}
