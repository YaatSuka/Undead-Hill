using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class TargetScript : MonoBehaviour {
	public bool isHit = false;
	public int destroyDelay = 5;
	
	private void Update () {
		if (isHit) {
			gameObject.GetComponent<Animator>().Play("Z_FallingBack");
			Destroy(gameObject, destroyDelay);
		}
	}
}