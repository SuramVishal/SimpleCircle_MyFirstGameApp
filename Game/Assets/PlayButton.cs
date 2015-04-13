using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	
	public void LevelChange(int k)
	{
				Application.LoadLevel (k);
		}
}
