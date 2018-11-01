using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefato{
	private int id;
	private string nome;
	private string descricao;
	private Efeito efeito;
	private Sprite icone;

	public Artefato(int id, string nome, string descricao, Efeito efeito, Sprite icone){
		this.id = id;
		this.nome = nome;
		this.descricao = descricao;
		this.efeito = efeito;
		this.icone = icone;
	}

	public int Id{
		get{return id;}
	}
	public string Nome{
		get{ return nome; }
	}
	public string Descricao{
		get{ return Descricao; }
	}
	public Efeito Efeito{
		get{ return efeito; }
	}
	public Sprite Icone{
		get{ return icone; }
	}
}
