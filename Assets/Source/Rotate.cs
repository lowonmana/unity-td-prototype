
using UnityEngine;

class Rotate : MonoBehaviour
{
	public float rotateSpeed = 0.0f;

	private void Update()
	{
		transform.Rotate( Vector3.forward * Time.deltaTime * rotateSpeed );
	}
}