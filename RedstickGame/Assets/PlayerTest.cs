
using UnityEngine;
using System.Collections;
using System.Globalization;
using UnityEngine.UI;

public class PlayerTest : MonoBehaviour
{


	// Use this for initialization
	void Start () {   
	    GameObject.FindGameObjectWithTag("UI").GetComponent<Text>().text = Random.value.ToString(CultureInfo.InvariantCulture);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
