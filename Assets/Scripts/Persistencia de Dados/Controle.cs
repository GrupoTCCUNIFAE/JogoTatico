using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary; // bibilioteca para salvar em arquivo binario
using System.IO;

public class Controle : MonoBehaviour {
	
	private  ControladorGeral jogador;
	private string caminhoArquivo;
	private PlayerData playerData;

	public void Start () {
		jogador = PlayerManager.instance.GetComponent<ControladorGeral>();
		caminhoArquivo = Application.persistentDataPath + "/informacoes.dat";
		Carregar ();
	}

	public void Salvar(){
		BinaryFormatter bf = new BinaryFormatter (); // classe responsavel para escrever
		FileStream file = File.Create (caminhoArquivo); //criar arquivo no caminho


		PlayerData data = new PlayerData ();
		Inventario inv = PlayerManager.instance.GetComponent<Inventario> ();

		data.vida = jogador.Vida;
		data.mana = jogador.Mana;
		data.arma = inv.Arma;
		data.armadura = inv.Armadura;
		data.itens = inv.Bolsa;
		data.magias = inv.Magias;
		data.magiasPreparadas = inv.MagiasPreparadas;

		bf.Serialize (file, data);

		file.Close ();
	}

	public void Carregar(){
		if (File.Exists (caminhoArquivo)) {

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (caminhoArquivo, FileMode.Open);

			playerData = (PlayerData)bf.Deserialize (file);
			file.Close ();
		} else {
			playerData = new PlayerData ();
		}
	}

	public PlayerData Data{
		get{return playerData;}
	}

	void OnApplicationQuit(){
		Salvar();
	}
}
