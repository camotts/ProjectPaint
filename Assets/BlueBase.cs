using UnityEngine;
using System.Collections;
using Assets;
using Assets.Scripts.Other.TeamEnum;

public class BlueBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        var entity = col.gameObject.GetComponent<IPlayer>();
        if (entity == null) return;
        if (entity.Team.TeamColor != Team.Blue)
        {
            Debug.Log("WIN");
        }
    }
}
