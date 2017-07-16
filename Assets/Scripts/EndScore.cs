using UnityEngine;
using System.Collections;

public class EndScore : MonoBehaviour {
	int gold;
	int score;
	public TextMesh GoldText;
	public TextMesh ScoreText;
	// Use this for initialization
	void Start () {
		gold=PlayerPrefs.GetInt("GoldCount");
		score=PlayerPrefs.GetInt("Score");

	}
	
	// Update is called once per frame
	void Update () {
		GoldText.text="x "+gold.ToString();
		ScoreText.text=score.ToString();
	}
}
