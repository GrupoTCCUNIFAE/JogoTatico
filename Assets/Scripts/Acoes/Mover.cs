using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Acao {

	private Vector2 direcao;
	private float distancia;
	private float distanciaAtual = 0;

	public Mover(Vector2 direcao, float distancia, string nome){
		this.direcao = direcao;
		this.distancia = distancia;
		Nome = nome;
	}

	public override void Update()
	{
		//refatorar
		DonoDaAcao.transform.position = new Vector3 (DonoDaAcao.transform.position.x+direcao.x*Time.deltaTime,DonoDaAcao.transform.position.y,DonoDaAcao.transform.position.z+direcao.y*Time.deltaTime);
		distanciaAtual += (direcao.x + direcao.y)*Time.deltaTime;

		if (distanciaAtual >= distancia || distanciaAtual <= -distancia)
			Finalizado = true;
	}
}
