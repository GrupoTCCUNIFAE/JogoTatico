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
		ParticleSystem.MainModule mainModule = DonoDaAcao.GetComponentInChildren<ParticleSystem> ().main;
		ParticleSystem.MinMaxGradient gradient = new ParticleSystem.MinMaxGradient ();

		DonoDaAcao.GetComponentInChildren<Light>().color = cor;
		DonoDaAcao.GetComponentInChildren<MeshRenderer>().material.color = cor;
		gradient.color = cor;
		mainModule.startColor = gradient;

		Finalizado = true;
	}
}
