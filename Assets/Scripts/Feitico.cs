using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Feitico{
	
	public int maximoDeAcoes;
	public GameObject donoDoFeitico;
	public int elemento;

	private List<Acao> acoes = new List<Acao>();
	private int acaoAtual = 0;
	private bool rodarAcoes = false;
	private bool fim = true;
	private bool instanciado = false;
	private GameObject feitico;
	private float custo;

	public void Update()
	{
		if (acaoAtual == acoes.Count && rodarAcoes)
			FinalizarFeitico ();

		if(rodarAcoes)
		{			
			if (!instanciado) {
				instanciado = true;
				Vector3 posicaoFeitico = new Vector3 (donoDoFeitico.transform.position.x, donoDoFeitico.transform.position.y, donoDoFeitico.transform.position.z);
				feitico = GameObject.Instantiate (Itens.magia[elemento].Prefab, posicaoFeitico, donoDoFeitico.transform.rotation);
				foreach (Acao acao in acoes) {
					acao.DonoDaAcao = feitico;
				}
			} else {
				acoes [acaoAtual].Update ();

				if (acoes [acaoAtual].Finalizado)
					acaoAtual++;
				if (feitico.GetComponent<Verificador> ().ColisaoComObstaculo) {
					FinalizarFeitico ();
				}
				if (feitico.GetComponent<Verificador> ().ColisaoComInimigo) {
					ControladorGeral inimigo = feitico.GetComponent<Verificador> ().Inimigo.GetComponent<ControladorGeral> ();
					int fra = 1, res = 1;

					foreach (EnumElementos fraqueza in inimigo.Fraquezas) {
						if (fraqueza == Itens.magia [elemento].Elemento) {
							fra *= 2;
							break;
						}
					}
					foreach (EnumElementos resistencia in inimigo.Resistencia) {
						if (resistencia == Itens.magia [elemento].Elemento) {
							res *= 2;
							break;
						}
					}

					inimigo.Vida -= (Itens.magia[elemento].Dano/res)*fra;
					FinalizarFeitico ();
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

	public Acao AcaoAtual{
		get{return acoes [acaoAtual];}
	}

	public float Custo{
		get{ return custo; }
		set{ custo = value; }
	}
}