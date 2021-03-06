using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Acao{

	private bool fim = false;
	private GameObject donoDaAcao;
	private string nome;
	private string id;

	public virtual void Update()
	{

	}

	public bool Finalizado
	{
		get{return fim;}
		set{fim = value;}
	}

	public string Nome
	{
		get{return nome;}
		set{nome = value;}
	}

	public GameObject DonoDaAcao
	{
		get{return donoDaAcao;}
		set{donoDaAcao = value;}
	}

	public string Id{
		get{return id;}
		set{id = value;}
	}
}