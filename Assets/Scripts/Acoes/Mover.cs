using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Acao {

	private int direcao;
	private float distancia;
	private float distanciaAtual = 0;
	private int velocidadeJogador;
	private float velocidade;

	public Mover(int direcao, float distancia, string nome){
		Id = "001("+Mathf.Sign(direcao)+")";
		this.direcao = direcao;
		this.distancia = distancia;
		Nome = nome;
		velocidadeJogador = PlayerManager.instance.GetComponent<PlayerStatus> ().velocidadeDaMagia;
	}

	public override void Update()
	{
		if (distanciaAtual >= distancia || distanciaAtual <= -distancia)
			Finalizado = true;

		velocidade = (velocidadeJogador * direcao) * Time.deltaTime;

		DonoDaAcao.transform.Translate (new Vector3 (0, 0, velocidade));

		distanciaAtual += velocidade;
	}
}
