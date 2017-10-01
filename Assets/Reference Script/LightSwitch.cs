using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {
	public void CloseLight()
	{
		gameObject.tag = "HubLight"; 
		gameObject.tag = "SFSceneElements";
		gameObject.tag = "HieroSlider";
		gameObject.SetActive(false);
	}
	public void OpenLight()
	{
		gameObject.tag = "HubLight"; 
		gameObject.tag = "SFSceneElements";
		gameObject.tag = "HieroSlider";
		gameObject.SetActive(true);
	}
}
