using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorarioNormal : MonoBehaviour {

	public float minutosDoCiclo;

	private Transform luz;
	private float tempoRotacao;
	private float tempoAtualSegundos = 0.0f;
	private int horaAtual;

	void Start()
	{
		tempoRotacao = 360 / (minutosDoCiclo * 60);
		luz = gameObject.GetComponent<Transform> ();
	}

	void Update()
	{
		float cicloEmSegundos = minutosDoCiclo * 60;
		float porcentagelAtual = tempoAtualSegundos/(cicloEmSegundos/100);

		horaAtual = (int)(porcentagelAtual*0.24f);
		tempoAtualSegundos +=  Time.deltaTime;
		luz.Rotate(tempoRotacao * Time.deltaTime, 0, 0);

		if(tempoAtualSegundos >= minutosDoCiclo*60)
		{
			tempoAtualSegundos = 0.0f;
		}
	}

	public int Hora{
		get{return horaAtual;}
	}
}