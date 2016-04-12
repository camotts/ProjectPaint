using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public Text text;
    public NetworkManager manager;

	// Use this for initialization
	void Start ()
	{
	    Network.Connect("68.105.145.37");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Try()
    {
        manager.StartClient();
        manager.networkAddress = "147.174.180.94";
        manager.networkPort = 8080;
        text.text = Network.TestConnection(true).ToString();
    }
}
