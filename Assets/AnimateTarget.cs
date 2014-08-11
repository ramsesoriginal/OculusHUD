using UnityEngine;
using System.Collections;

public class AnimateTarget : MonoBehaviour {

	public Transform last;
	public Transform first;
	public float tolerance;
	public float speed;

	private Vector3 min;
	private Vector3 max;
	public bool forward;

	// Use this for initialization
	void Start () {
		min = first.position;
		max = last.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (forward) {
			if (transform.position.z - tolerance <= min.z) {
				forward = false;
			} else {
				transform.position = Vector3.Lerp (transform.position, min, speed);
				if (Random.Range(0,100)==1) {
					forward = false;
				}
			}
		} else {
			if (transform.position.z + tolerance >= max.z) {
				forward = true;
			} else {
				transform.position = Vector3.Lerp (transform.position, max, speed);
				if (Random.Range(0,100)==1) {
					forward = true;
				}
			}
		}
	}
}
