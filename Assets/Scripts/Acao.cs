using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Acao{

	private bool fim = false;
	private GameObject donoDaAcao;

	public virtual void Update()
	{

	}

	public bool Finalizado
	{
		get{return fim;}
		set{fim = value;}
	}

	public GameObject DonoDaAcao{
		get{return donoDaAcao;}
		set{donoDaAcao = value;}
	}
}