using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{

	public void back ()
	{
		Application.LoadLevel ("GamePlay");
	}
}
