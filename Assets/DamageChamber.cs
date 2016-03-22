using UnityEngine;
using System.Collections;
using Assets;

public class DamageChamber : MonoBehaviour
{

    public int Damage = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        var player = col.gameObject.GetComponent<IPlayer>();
        if (player == null) return;
        player.TakeDamage(10);
    }
}
