using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
	public Text Score;
	public GameObject ResetButton;
	public GameObject GameOverText;
	public bool gameover;
	// Use this for initialization
	void Start ()
	{
		gameover = false;
		GameOverText.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!gameover)
			Score.text = Time.frameCount.ToString ();
	}

	public void OnTriggerEnter2D (Collider2D col)
	{

		Time.timeScale = 0;
		GameOverText.SetActive (true);
		gameover = true;
		ResetButton.SetActive (true);



	}

	public void MoveLeft ()
	{
		transform.position += new Vector3 (-01f, 0, 0);
	}
	public void MovrRight ()
	{
		transform.position += new Vector3 (1f, 0, 0);
	}
}
