// A grenade
// - instantiates a explosion prefab when hitting a surface
// - then destroys itself

using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {
	public Transform explosionPrefab;
	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "Ground") {

			ContactPoint contact = collision.contacts [0];
			Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate (explosionPrefab, pos, rot);
			Destroy (gameObject);
		}

	}
}
		