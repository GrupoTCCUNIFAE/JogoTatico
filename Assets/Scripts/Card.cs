using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card{


	private string nome;
	private string descricao;
	private Sprite imagem;
	private float ataque;
	private float defesa;
	private EnumElementos tipoDano;
	private List<EnumElementos> resistencias;
	private List<EnumElementos> fraquesas;

	public Card(string nome, string descricao, Sprite imagem, float ataque, float defesa, EnumElementos tipoDano, List<EnumElementos> resistencias, List<EnumElementos> fraquesas){

		this.nome = nome;
		this.descricao = descricao;
		this.imagem = imagem;
		this.ataque = ataque;
		this.defesa = defesa;
		this.tipoDano = tipoDano;
		this.resistencias = resistencias;
		this.fraquesas = fraquesas;

	}

	public string Nome{
		get{return nome;}
		set{nome = value;}
	}
	public string Descricao{
		get{return descricao;}
		set{descricao = value;}
	}
	public Sprite Imagem{
		get{return imagem;}
		set{imagem = value;}
	}
	public float Ataque{
		get{return ataque;}
		set{ataque = value;}
	}
	public float Defesa{
		get{return defesa;}
		set{defesa = value;}
	}
	public EnumElementos TipoDano{
		get{return tipoDano;}
		set{tipoDano = value;}
	}
	public List<EnumElementos> Resistencias{
		get{return resistencias;}
		set{resistencias = value;}
	}
	public List<EnumElementos> Fraquesas{
		get{return fraquesas;}
		set{fraquesas = value;}
	}
}
