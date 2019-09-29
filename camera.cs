using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

	public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
	public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
	public Camera ob;

	Vector3 RAY(Vector3 t)
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(t);
		if (Physics.Raycast(ray, out hit))
		{
			Debug.Log(hit.point);
			Vector3 targetpos = hit.point;
			targetpos.z = -1f; ;
			return targetpos;
		}
		return new Vector3(0, 0, 0);
	}


	void Update()
	{
		// If there are two touches on the device...
		if (Input.touchCount == 2)
		{
			// Store both touches.
			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);

			// Find the position in the previous frame of each touch.
			Vector3 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector3 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			// Find the magnitude of the vector (the distance) between the touches in each frame.
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			// Find the difference in the distances between each frame.
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;


			// Otherwise change the field of view based on the change in distance between the touches.
			ob.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

			// Clamp the field of view to make sure it's between 0 and 180.
			ob.fieldOfView = Mathf.Clamp(ob.fieldOfView, 0.1f, 179.9f);

		}
	}

}
