using UnityEngine;
using System.Collections;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

public class Bullet : MonoBehaviour
{

    public float LifeTime = 1f;

    private float Timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Timer >= LifeTime)
	    {
	        Destroy(this.gameObject);
	    }
	    else
	    {
	        Timer += Time.deltaTime;
	    }

        
        
	}
}
