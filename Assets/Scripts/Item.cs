using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item{

	//Tornar todos private
	public string nome;
	public string descricao;
	public EnumTipoItem tipo;
	public float valor;
	public float peso;
	public float defesa;
	public float ataque;
	public float cura;
	public Sprite imagem;
	public GameObject modelo;

	public Item(string nome, string descricao, EnumTipoItem tipo, float valor, float peso, float defesa, float ataque, Sprite imagem, GameObject modelo, float cura){
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
	public GameObject Modelo{
		get{return modelo;}
		set{modelo = value;}
	}
	public float Cura{
		get{return cura;}
		set{cura = value;}
	}
}
