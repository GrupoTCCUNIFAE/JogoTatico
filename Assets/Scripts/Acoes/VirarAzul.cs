using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirarAzul : Acao {

	private Color32 cor;

	public VirarAzul(string nome){
		Nome = nome;
		Id = 3;
		this.cor = new Color32 (21, 0, 129, 255);
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
