using UnityEngine;
using System.Collections;
using System;

public class Gun : MonoBehaviour
{

    public Transform Barrel;
    public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    internal void Fire()
    {
        var clone = Instantiate(Bullet, Barrel.position, gameObject.transform.parent.rotation) as GameObject;
        clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * 1000f);
    }
}
