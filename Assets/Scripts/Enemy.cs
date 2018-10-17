using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Handles interaction with the Enemy */

[RequireComponent(typeof(ControladorGeral))]
public class Enemy : Interactable
{

    PlayerManager playerManager;
    ControladorGeral myStats;


    void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<ControladorGeral>();
    }

    public override void Interact()
    {
        base.Interact();
		ControladorGeral playerCombat = playerManager.player.GetComponent<ControladorGeral>();
        if (playerCombat != null)
        {
			float ataque = 0;

			if (myStats.Ataque - playerCombat.Armadura > 0)
				ataque = myStats.Ataque - playerCombat.Armadura;

			playerCombat.Vida -= ataque;
        }
    }

}