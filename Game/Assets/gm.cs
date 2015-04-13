using UnityEngine;
using System.Collections;

public class gm : MonoBehaviour {
	
	public static int PlayerScore1 = 0;
	public GUISkin layout;
	Transform theBall;
    void Start() {
	theBall = GameObject.FindGameObjectWithTag("Ball").transform;
		}
	public static void Score (string wallID) {
				if (wallID == "border2") {
						PlayerScore1++;
				} else if (wallID == "resetwall") {
			Application.LoadLevel(2);		

				
				}
		}
	
	void OnGUI(){
				GUI.skin = layout;
				GUI.Label (new Rect (Screen.width / 2 - 150 - 12, 20, 100, 100), "SCORE :  " + PlayerScore1);
		        
		}
		

	}

