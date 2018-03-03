using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorarioNormal : MonoBehaviour {

    public GameObject obj;
    public float tempoRotacaoM = 5.0f;
    private float tempoR = 0.0f; 

    public float tempo = 0.0f;




    // Use this for initialization
    void Start()
    {
        tempoR = 360 / (tempoRotacaoM * 60);
    }

    // Update is called once per frame
    void Update()
    {

        //24 horas em 5 minutos

        tempo +=  Time.deltaTime;
        obj.transform.Rotate(tempoR * Time.deltaTime, 0, 0);
        if(tempo >= 300.0f)
        {
            tempo = 0.0f;
        }
    }
}