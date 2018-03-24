using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Feitico{
	
	public int maximoDeAcoes;
	public GameObject donoDoFeitico;
	public GameObject prefabFeitico;

	private List<Acao> acoes = new List<Acao>();
	private int acaoAtual = 0;
	private bool rodarAcoes = false;
	private bool fim = true;
	private bool instanciado = false;
	private GameObject feitico;

	public void Update()
	{
		if (acaoAtual == acoes.Count && rodarAcoes)
			FinalizarFeitico ();

		if(rodarAcoes)
		{			
			if (!instanciado) 
			{
				instanciado = true;
				feitico = GameObject.Instantiate (prefabFeitico, new Vector3(donoDoFeitico.transform.position.x, donoDoFeitico.transform.position.y, donoDoFeitico.transform.position.z+1), Quaternion.Euler (0, 0, 0));
				foreach (Acao acao in acoes) 
				{
					acao.DonoDaAcao = feitico;
				}
			}
			acoes[acaoAtual].Update();

			if(acoes[acaoAtual].Finalizado)
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

	public void FinalizarFeitico()
	{
		GameObject.Destroy (feitico);
		acoes = new List<Acao>();
		acaoAtual = 0;
		rodarAcoes = false;
		fim = true;
		instanciado = false;
	}

	public bool finalizado{
		get{return fim;}
		set{fim = value;}
	}

	public void ExecutarAcoes(){
		acaoAtual = 0;
	}

	public bool Rodar{
		get{ return rodarAcoes; }
		set{ rodarAcoes = value; }
	}

	public List<Acao> Acoes{
		get{return acoes;}
		set{acoes = value;}
	}

	public string printAcoes(){
		string retorno = "";

		foreach(Acao acao in acoes){
			retorno += acao.Nome+"\n";
		}

		return retorno;
	}
}