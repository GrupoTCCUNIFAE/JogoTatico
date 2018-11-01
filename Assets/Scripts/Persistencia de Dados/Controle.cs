using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine; // bibilioteca para salvar em arquivo binario
using System.IO;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour {
	
	private  PlayerStatus jogador;
	private string caminhoArquivo;
	private PlayerData playerData;

	public void Start () {
		jogador = PlayerManager.instance.GetComponent<PlayerStatus>();
		caminhoArquivo = Application.persistentDataPath + "/informacoes.dat";
		print (caminhoArquivo);
		Carregar ();
	}

	public void Salvar(){
		BinaryFormatter bf = new BinaryFormatter (); // classe responsavel para escrever
		FileStream file = File.Create (caminhoArquivo); //criar arquivo no caminho


		PlayerData data = new PlayerData ();
		Inventario inv = PlayerManager.instance.GetComponent<Inventario> ();

		data.vida = jogador.Vida;
		data.mana = jogador.Mana;
		data.vidaMaxima = jogador.VidaMaxima;
		data.manaMaxima = jogador.ManaMaxima;
		data.velocidade = jogador.Velocidade;
		data.arma = inv.Arma;
		data.armadura = inv.Armadura;
		data.itens = inv.Bolsa;
		data.magias = inv.Magias;
		data.magiasPreparadas = inv.MagiasPreparadas;
		data.cards = inv.Cards;
		data.artefato = inv.Artefato;

		Vector3 posicao = PlayerManager.instance.player.transform.position;

		data.fase = SceneManager.GetActiveScene ().name;
		data.x = posicao.x;
		data.y = posicao.y;
		data.z = posicao.z;

		data.xpAtual = jogador.xp.XpAtual;
		data.level = jogador.xp.Level;

		bf.Serialize (file, data);

		file.Close ();
	}

	public void Carregar(){
		if (File.Exists (caminhoArquivo)) {

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (caminhoArquivo, FileMode.Open);

			playerData = (PlayerData)bf.Deserialize (file);
			file.Close ();

			PlayerManager.instance.player.transform.position = new Vector3 (playerData.x, playerData.y, playerData.z);
		}
	}

	public PlayerData Data{
		get{return playerData;}
	}

	void OnApplicationQuit(){
		Salvar();
	}
}
