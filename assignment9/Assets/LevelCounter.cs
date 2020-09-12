using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour {

	public static int level = 1;
	public Text leveler;
	
	// Use this for initialization
	void Start () {
		leveler.text = "LEVEL " + level;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
