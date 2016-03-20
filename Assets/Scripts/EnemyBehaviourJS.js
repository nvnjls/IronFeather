#pragma strict

var micController:GameObject;
function Start () {

}

function Update () {

var getLoudness=micController.GetComponent(MicControl).loudness;

	if (getLoudness >= 0.01) {
	transform.position -=  Vector3 (0, 0.05f, 0);
	}
	else
	transform.position -=  Vector3 (0, -0.1f, 0);
}