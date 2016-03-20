using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("i"))
			this.gameObject.transform.position -= new Vector3 (0, 0.05f, 0);
		else
			this.gameObject.transform.position -= new Vector3 (0, -0.1f, 0);


	}
}
