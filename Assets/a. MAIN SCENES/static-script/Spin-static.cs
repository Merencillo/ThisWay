using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	public float speed = 30f;
    public float x;
    public float y;
    public float z;

	void Update ()
	{
		transform.Rotate(new Vector3(x,y,z), speed * Time.deltaTime);
	}
}