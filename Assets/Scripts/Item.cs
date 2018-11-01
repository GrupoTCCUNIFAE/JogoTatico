using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item{

	private string nome;
	private string descricao;
	private EnumTipoItem tipo;
	private float valor;
	private float peso;
	private float defesa;
	private float ataque;
	private float cura;
	private Sprite imagem;
	private Mesh modelo;
	private int id;
	private float mana;
	private Efeito efeito;

	public Item(string nome, string descricao, EnumTipoItem tipo, float valor, float peso, float defesa, float ataque, Sprite imagem, Mesh modelo, float cura, int id, float mana){
		this.nome = nome;
		this.descricao = descricao;
		this.tipo = tipo;
		this.valor = valor;
		this.peso = peso;
		this.defesa = defesa;
		this.ataque = ataque;
		this.imagem = imagem;
		this.modelo = modelo;
		this.cura = cura;
		this.id = id;
		this.mana = mana;
	}

	public Item(int id, string nome, string descricao, Efeito efeito, Sprite imagem){
		this.id = id;
		this.nome = nome;
		this.descricao = descricao;
		this.efeito = efeito;
		this.imagem = imagem;
		this.tipo = EnumTipoItem.Artefato;
	}
	public string Nome{
		get{return nome;}
		set{nome = value;}
	}
	public string Descricao{
		get{return descricao;}
		set{descricao = value;}
	}
	public EnumTipoItem Tipo{
		get{return tipo;}
		set{tipo = value;}
	}
	public float Valor{
		get{return valor;}
		set{valor = value;}
	}
	public float Peso{
		get{return peso;}
		set{peso = value;}
	}
	public float Defesa{
		get{return defesa;}
		set{defesa = value;}
	}
	public float Ataque{
		get{return ataque;}
		set{ataque = value;}
	}
	public Sprite Imagem{
		get{return imagem;}
		set{imagem = value;}
	}
	public Mesh Modelo{
		get{return modelo;}
		set{modelo = value;}
	}
	public float Cura{
		get{return cura;}
		set{cura = value;}
	}
	public float Mana{
		get{return mana;}
		set{mana = value;}
	}
	public int Id{
		get{return id;}
		set{id = value;}
	}
	public Efeito Efeito{
		get{return efeito;}
	}
}
