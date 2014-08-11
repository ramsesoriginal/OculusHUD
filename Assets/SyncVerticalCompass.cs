using UnityEngine;
using System.Collections;

public class SyncVerticalCompass : MonoBehaviour {

	public Transform forward;
	public Transform ovrleft;
	public Vector3 offset;
		
	// Update is called once per frame
	void Update () {
		transform.position = forward.position + offset + new Vector3(0,ovrleft.localPosition.y,ovrleft.localPosition.z);
		var rot = forward.rotation.eulerAngles;
		rot = new Vector3(rot.x,rot.y+90,rot.z+90);
		transform.rotation =  Quaternion.Euler(rot);
	}
}
