using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WebcamController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var deviceName = WebCamTexture.devices[0].name;

        var webCamTexture = new WebCamTexture(deviceName, 1280, 720, 30);

	    var w = Screen.width;
	    var h = Screen.height;
	    var insertX = -(w/2);
	    var insertY = -(h/2);



        webCamTexture.Play();
        Screen.orientation = ScreenOrientation.Portrait;
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        //GetComponent<Image>().transform.Rotate(0,0,-90);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
