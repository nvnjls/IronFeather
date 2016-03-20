#pragma strict

var micController:GameObject;
var warningText:GameObject;
var speed:float;
var anim:Animator;
function Start () {
	speed = 0.5;
	warningText.SetActive(false);
}

function Update () {

//Calls the loudness value of selected controller (in this case the controller in micController variable).
var getLoudness=micController.GetComponent(MicControl).loudness;

	if (getLoudness >= 0.01)
	 {
		var offset1 =  Vector2 (0,Time.time*speed);
			GetComponent(Renderer).material.mainTextureOffset = offset1;
			warningText.SetActive(false);
			anim.SetTrigger("Fly");
	 }
	
	else
	{
		warningText.SetActive(true);
		var offset2 =  Vector2 (0, Time.time*(-speed/4));
		GetComponent(Renderer).material.mainTextureOffset = offset2;
		anim.SetTrigger("Open");
			
	}
}