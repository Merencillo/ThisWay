using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	public Canvas JointsCanvas;
	public Button startText;
	public Button exitText;

	void Start()
	{
		startText = startText.GetComponent<Button> ();
	}

	public void changeToScene(int changeTheScene)
	{
		SceneManager.LoadScene (changeTheScene);
	}
}
