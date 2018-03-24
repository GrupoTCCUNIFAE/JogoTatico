using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : Acao {

	private List<Acao> acoes;
	private int acaoAtual = 0;
	private bool rodarAcoes = false;
	private int condicao;
	private bool condicaoBool;
	private List<Acao> acoesVerdadeiras;
	private List<Acao> acoesFalsas;

	public Condicional(int condicao, List<Acao> acoesVerdadeiras, List<Acao> acoesFalsas){
		Id = "004("+condicao+")[";
		foreach (Acao acao in acoesVerdadeiras) {
			Id += acao.Id+",";
		}
		Id = Id.Remove(Id.Length - 1);
		Id += "][";
		foreach (Acao acao in acoesFalsas) {
			Id += acao.Id+",";
		}
		Id = Id.Remove(Id.Length - 1);
		Id += "]";

		this.condicao = condicao;
		this.acoesFalsas = acoesFalsas;
		this.acoesVerdadeiras = acoesVerdadeiras;
		this.Nome = "Condicional";
	}

	public override void Update()
	{		
		switch (condicao) {
		case 1:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().InimigoFrente;
			break;
		case 2:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().InimigoDireita;
			break;
		case 3:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().InimigoEsquerda;
			break;
		case 4:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObjetoFrente;
			break;
		case 5:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObjetoDireita;
			break;
		case 6:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObjetoEsquerda;
			break;
		case 7:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObstaculoFrente;
			break;
		case 8:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObstaculoDireita;
			break;
		case 9:
			condicaoBool = DonoDaAcao.GetComponent<Verificador> ().ObstaculoEsquerda;
			break;
	}
		if (acoes == null) {
			if (condicaoBool) {			
				acoes = acoesVerdadeiras;
			} else {
				acoes = acoesFalsas;
			}
		} else {			
			if (acaoAtual == acoes.Count)
				Finalizar ();
			else {			
				acoes [acaoAtual].DonoDaAcao = DonoDaAcao;	
				acoes [acaoAtual].Update ();

				if (acoes [acaoAtual].Finalizado) {
					acaoAtual++;
				}
			}
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

	public void Finalizar()
	{
		Finalizado = true;
	}

	public void ExecutarAcoes(){
		acaoAtual = 0;
	}

	public bool Rodar{
		get{ return rodarAcoes; }
		set{ rodarAcoes = value; }
	}

	public string printAcoes(){
		string retorno = "";

		foreach(Acao acao in acoes){
			retorno += acao.Nome+"\n";
		}

		return retorno;
	}
}
