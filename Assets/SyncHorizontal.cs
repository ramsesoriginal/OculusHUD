using UnityEngine;
using System.Collections;

public class SyncHorizontal : MonoBehaviour {

	public Transform forward;
	public Transform ovrleft;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position = forward.position + offset + new Vector3(0,ovrleft.localPosition.y,ovrleft.localPosition.z);
		var rot = ovrleft.rotation.eulerAngles;
		rot = new Vector3(rot.x,0,0);
		transform.rotation =  Quaternion.Euler(rot);
	}
}
