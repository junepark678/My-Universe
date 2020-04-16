using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{

	public float xSpread;
	public float zSpread;
	public float yOffset;
	public Transform centerPoint;

	public float rotSpeed;
	public bool rotateClockwise;
	float timer = 0;
	public Vector3 axis = Vector3.up;
	public Vector3 desiredPosition;
	public float radiusSpeed = 0.5f;
	public float rotationSpeed = 80.0f;

	void Rotate()
	{
		if (rotateClockwise)
		{
			float x = -Mathf.Cos(timer) * xSpread;
			float z = Mathf.Sin(timer) * zSpread;
			Vector3 pos = new Vector3(x, yOffset, z);
			transform.position = pos + centerPoint.position;
		}
		else
		{
			float x = Mathf.Cos(timer) * xSpread;
			float z = Mathf.Sin(timer) * zSpread;
			Vector3 pos = new Vector3(x, yOffset, z);
			transform.position = pos + centerPoint.position;
		}
	}
	void Update()
	{
		transform.RotateAround(centerPoint.position, axis, rotationSpeed * Time.deltaTime);
		desiredPosition = (transform.position - centerPoint.position).normalized * xSpread + centerPoint.position;
		transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
	}
}
