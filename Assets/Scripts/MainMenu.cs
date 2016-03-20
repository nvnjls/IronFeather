using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public void Play ()
	{
		Application.LoadLevelAsync ("GamePlay");
	}
	public void credits ()
	{
		Application.LoadLevel ("Credits");
	}
}
