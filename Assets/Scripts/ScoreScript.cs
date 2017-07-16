using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public TextMesh distanceScore;
	public TextMesh goldScore;
	int score=0;
	int gold=0;
	// Use this for initialization
	void Start(){
		goldScore.text="x 0";
	}

	void Awake () {
		InvokeRepeating ("UpdateScoreText", 0.5f, 0.5f);
	}

	void UpdateScoreText(){
		score++;
		PlayerPrefs.SetInt("Score", score);
	}

	void Update(){
		distanceScore.text=score.ToString();
		gold=PlayerPrefs.GetInt("GoldCount");
		goldScore.text="x "+gold.ToString();
	}
}
