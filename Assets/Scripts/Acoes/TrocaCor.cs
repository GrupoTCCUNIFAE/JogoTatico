using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCor : Acao {

	private Color32 cor;

	public TrocaCor(string nome, Color32 cor){
		Nome = nome;
		Id = "003("+cor.r+")("+cor.g+")("+cor.b+")";
		this.cor = cor;
	}

	public override void Update()
	{
		//refatorar
		DonoDaAcao.GetComponentInChildren<Light>().color = cor;
		DonoDaAcao.GetComponent<MeshRenderer>().material.color = cor;
		ParticleSystem.MainModule mainModule = DonoDaAcao.GetComponentInChildren<ParticleSystem> ().main;
		ParticleSystem.MinMaxGradient gradient = new ParticleSystem.MinMaxGradient ();
		gradient.color = cor;
		mainModule.startColor = gradient;
		Finalizado = true;
	}
}
