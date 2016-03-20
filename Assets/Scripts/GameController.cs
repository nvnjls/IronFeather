using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	internal Vector2 EnemyPosition;
	public float TimeDelay = 1f;
	internal float Timer;
	public GameObject Enemy;

	public GameObject GameOverText;
	public GameObject ResetButton;
	public bool gameover;

	// Use this for initialization
	void Start ()
	{
		ResetButton.SetActive (false);
		GameOverText.SetActive (false);
		Timer = TimeDelay;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Timer -= Time.deltaTime;
		if (Timer <= 0) {
			Timer = TimeDelay;
			EnemyPosition = new Vector2 (Random.Range (-5, 5), 17);
			Instantiate (Enemy, EnemyPosition, transform.rotation);
		}
	
	}
	public void Reset ()
	{
		Application.LoadLevel (0);
	}
}
