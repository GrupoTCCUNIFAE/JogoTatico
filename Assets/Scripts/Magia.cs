using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia{

	private string nome;
	private GameObject prefab;
	private Sprite imagem;
	private float dano;
	private float multiplicadorDeMana;

	public Magia(string nome, GameObject prefab, Sprite imagem, float dano, float multiplicadorDeMana){
		this.nome = nome;
		this.prefab = prefab;
		this.imagem = imagem;
		this.dano = dano;
		this.multiplicadorDeMana = multiplicadorDeMana;
	}
	public string Nome{
		get{return nome;}
		set{nome = value;}
	}
	public GameObject Prefab{
		get{return prefab;}
		set{prefab = value;}
	}
	public Sprite Imagem{
		get{return imagem;}
		set{imagem = value;}
	}
	public float Dano{
		get{return dano;}
		set{dano = value;}
	}
	public float MultiplicadorDeMana{
		get{return multiplicadorDeMana;}
		set{multiplicadorDeMana = value;}
	}
}
