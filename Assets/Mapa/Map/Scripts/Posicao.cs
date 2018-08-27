using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicao : MonoBehaviour {

	private string nome;
	private float posicaoX;
	private float posicaoY;


	public  Posicao(string nome, float posicaoX, float posicaoY){
		this.nome = nome;
		this.posicaoX = posicaoX;
		this.posicaoY = posicaoY;

	}

	public string Nome{
		get{return nome; }
		set{nome = value; }
	}

	public float PosicaoX{
		get{return posicaoX; }
		set{posicaoX = value; }
	}

	public float PosicaoY{
		get{return posicaoY; }
		set{posicaoY = value; }
	}

}
