using UnityEngine;
using System.Collections;

public class FollowingHero : MonoBehaviour {

	public GameObject hero;

	private Vector3 currVelocity;

	public float smooth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newCameraPosition = new Vector3 (hero.transform.position.x, hero.transform.position.y, transform.position.z);

		transform.position = Vector3.SmoothDamp (transform.position, newCameraPosition, ref currVelocity, smooth);
	
	}
}
