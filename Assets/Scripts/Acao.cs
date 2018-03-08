using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Acao{

	private bool fim = false;
	
	public virtual void Update()
	{

	}

	public bool finalizado
	{
		get{return fim;}
		set{fim = value;}
	}
}