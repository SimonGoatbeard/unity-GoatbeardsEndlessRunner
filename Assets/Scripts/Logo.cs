using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("nextScene", 1); 
	}
			
	void nextScene () { 
		Application.LoadLevel(1); 
	}

}
