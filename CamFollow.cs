using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

	public GameObject target;
	public float xOffset = -12f;
	public float yOffset = 9f;
	public float zOffset = -12f;

	public float turn = 0f;

	public float lerpSpeed = 0.02f;
	public float rotateSpeed = 0.1f;


	//if choppy, try LateUpdate or Update

	void FixedUpdate() {
    	this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(target.transform.position.x + xOffset, target.transform.position.y + yOffset, target.transform.position.z + zOffset), lerpSpeed);

		this.transform.LookAt(target.transform.position);

		if(this.transform.rotation.x != 30) {
			this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler (-20f,30f,this.transform.rotation.z), rotateSpeed);
		}
	}
}
