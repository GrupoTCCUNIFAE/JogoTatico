using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card{

	private Sprite imagem;
	private string nome;
	private string descricao;
	private List<string> fraquesas;
	private List<string> resistencias;
	private List<string> imunidades;

	public Card(Sprite imagem, string nome, string descricao, List<string> fraquesas, List<string> resistencias, List<string> imunidades){
		this.imagem = imagem;
		this. nome = nome;
		this. descricao = descricao;
		this. fraquesas = fraquesas;
		this. resistencias = resistencias;
		this. imunidades = imunidades;
	}

	public Sprite Imagem{
		get{return imagem;}
		set{ imagem = value; }
	}
	public string Nome{
		get{return nome;}
		set{nome = value;}
	}
	public string Descricao{
		get{return descricao;}
		set{descricao = value;}
	}
	public List<string> Fraquesas{
		get{return fraquesas;}
		set{fraquesas = value;}
	}
	public List<string> Resistencias{
		get{return resistencias;}
		set{resistencias = value;}
	}
	public List<string> Imunidades{
		get{return imunidades;}
		set{imunidades = value;}
	}
}
