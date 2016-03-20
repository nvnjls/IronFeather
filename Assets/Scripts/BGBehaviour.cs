using UnityEngine;
using System.Collections;

public class BGBehaviour : MonoBehaviour
{
	public float speed = 0.5f;
	public bool MovingUp;
	public GameObject MicController;

	
	// Use this for initialization
	void Start ()
	{
		MovingUp = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//float Loudness = MicController.GetComponent <MicControl> ().loudness;
		if (1 >= 0.1f) {
			Vector2 offset = new Vector2 (0, Time.time * speed);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
			MovingUp = false;
		} else {
			Vector2 offset = new Vector2 (0, Time.time * -speed / 4);
			GetComponent<Renderer> ().material.mainTextureOffset = offset;
			MovingUp = true;
		}
	}
}
