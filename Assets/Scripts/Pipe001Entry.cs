using UnityEngine;
using System.Collections;

public class Pipe001Entry : MonoBehaviour {
	GameObject PipeEntry;
	int StoodOn;

	void OnTriggerEnter(Collider col){
		StoodOn = 1;
	}

	void OnTriggerExit(Collider col){
		StoodOn = 0;
	}

	void Update(){
		if (Input.GetKey ("GoDown")) {
			if (StoodOn == 1) {
				transform.position = Vector3 (0, -1000, 0);
				WaitingForPipe ();
			}
		}
	}

	void WaitingForPipe(){
		PipeEntry.GetComponent<Animator>.
	}
}
