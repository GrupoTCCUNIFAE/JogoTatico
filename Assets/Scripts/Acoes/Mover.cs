using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Acao {

	private int direcao;
	private float distancia;
	private float distanciaAtual = 0;

	public Mover(int direcao, float distancia, string nome){
		Id = "001("+Mathf.Sign(direcao)+")";
		this.direcao = direcao;
		this.distancia = distancia;
		Nome = nome;
	}

	public override void Update()
	{
		DonoDaAcao.transform.Translate (new Vector3 (0, 0, direcao*Time.deltaTime));
		distanciaAtual += direcao*Time.deltaTime;

		if (distanciaAtual >= distancia || distanciaAtual <= -distancia)
			Finalizado = true;
	}
}
