using UnityEngine;
using System.Collections;

public class TapToContinue : MonoBehaviour {
	public TextMesh Tap;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Tap.text="Please wait...";
			Application.LoadLevel(2); 
		}
	}
}
