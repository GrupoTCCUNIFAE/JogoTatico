using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXPUI : MonoBehaviour {

	public GameObject levelUpUI;

	private PlayerStatus playerStat;
	private int levelAtual;

	void Start(){
		playerStat = PlayerManager.instance.GetComponent<PlayerStatus> ();
		levelAtual = playerStat.xp.Level;
	}

	public void AumentarVida(){
		playerStat.VidaMaxima += playerStat.xp.Level*10;
		levelUpUI.SetActive (false);
	}

	public void AumentarMana(){
		playerStat.ManaMaxima += playerStat.xp.Level*10;
		levelUpUI.SetActive (false);
	}

	public void NovoElemento(){
		PlayerManager.instance.GetComponent<Inventario> ().Magias.Add (0);
		levelUpUI.SetActive (false);
	}

	public void AumentarVelocidade(int value){
		playerStat.Velocidade += value;
		levelUpUI.SetActive (false);
	}

	void Update () {
		if(playerStat.xp.Level > levelAtual){
			levelAtual = playerStat.xp.Level;
			levelUpUI.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			playerStat.xp.XpAtual += 100;
		}
	}
}
