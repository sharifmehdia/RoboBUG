﻿using UnityEngine;
using System.Collections;

public class sidebarcomment : MonoBehaviour {

	public GameObject level;
	int levelnum=0;
	// Use this for initialization
	void Start () {
		GUIText tm = GetComponent<GUIText> ();
		tm.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		GUIText tm = GetComponent<GUIText> ();
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		if (levelnum == 4 || levelnum == 6) {
			tm.text = "2. Commenter";
		}
		else{
			tm.text = "";
		}
		if (tm.text == "2. Commenter"){
			if (Input.GetKeyDown("0")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("1")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("2")) {this.GetComponent<GUIText>().color = Color.green;
			}
			if (Input.GetKeyDown("3")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("4")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("5")) {this.GetComponent<GUIText>().color = Color.black;
			}
			if (Input.GetKeyDown("6")) {this.GetComponent<GUIText>().color = Color.black;
			}
		}
	}
}