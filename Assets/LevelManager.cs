using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log (name);
	}

	public void QuitRequest() {
		Debug.Log ("Quit");
	}

}
