using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary; // bibilioteca para salvar em arquivo binario
using System.IO;



[Serializable]
class PlayerData{


	//ainda tem que deixar private e criar getters e setters


	public float vida;
	public float mana;
	public List<int> itens;

}



public class Controle : MonoBehaviour {

	public static Controle controle;
	public  ControladorGeral jogador;

	private string caminhoArquivo;

	void Awake () {

		if (controle == null) {
			controle = this;
		} else {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);

		caminhoArquivo = Application.persistentDataPath + "/informacoes.dat";
		Debug.Log (Application.persistentDataPath + "/informacoes.dat");

	}

	public void Salvar(){
		BinaryFormatter bf = new BinaryFormatter (); // classe responsavel para escrever
		FileStream file = File.Create (caminhoArquivo); //criar arquivo no caminho


		PlayerData data = new PlayerData ();

		data.vida =jogador.Vida;
		data.mana =jogador.Mana;

		bf.Serialize (file, data);

		file.Close ();
	}

	public void Carregar(){
		if (File.Exists (caminhoArquivo)) {

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (caminhoArquivo, FileMode.Open);

			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();
			jogador.Vida = data.vida;
			jogador.Mana = data.mana;
		}
	}


}
