using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Turno{
	
	public int maximoDeAcoes;
	public GameObject donoDoTurno;

	private List<Acao> acoes = new List<Acao>();
	private int acaoAtual = 0;
	private bool rodarAcoes = false;
	private bool fim = true;

	public void Update()
	{
		if (acaoAtual >= acoes.Count)
			FinalizarTurno ();

		if(rodarAcoes)
		{			
			acoes[acaoAtual].Update();

			if(acoes[acaoAtual].finalizado)
				acaoAtual++;
		}		
	}

	public void AdicionarAcao(Acao acao)
	{
		acoes.Add(acao);
	}

	public void RemoverAcao(Acao acao)
	{
		acoes.Remove(acao);
	}

	public void FinalizarTurno()
	{
		rodarAcoes = false;
		acoes = new List<Acao>();
		fim = true;
	}

	public bool finalizado{
		get{return fim;}
		set{fim = value;}
	}

	public void ExecutarAcoes(){
		acaoAtual = 0;
	}

	public bool rodar{
		get{ return rodarAcoes; }
		set{ rodarAcoes = value; }
	}
}