using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virar : Acao {

	private int direcao;

	public Virar(int direcao, string nome){
		Id = "002("+Mathf.Sign (direcao)+")";
		this.direcao = direcao;
		Nome = nome;
	}

	public override void Update()
	{
		DonoDaAcao.transform.Rotate (new Vector3 (0, direcao, 0));

		Finalizado = true;
	}
}
