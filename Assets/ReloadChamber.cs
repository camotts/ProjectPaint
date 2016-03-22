using UnityEngine;
using System.Collections;
using Assets;
using Assets.Scripts.Other.TeamEnum;
using UnityEditor;

public class ReloadChamber : MonoBehaviour
{

    public Team Team;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        var player = col.gameObject.GetComponent<IPlayer>();
        if (player == null || player.Team.TeamColor != Team) return;
        player.Ammo = player.MaxAmmo;
    }
    
}
