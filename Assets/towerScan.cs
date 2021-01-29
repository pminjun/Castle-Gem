using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerScan : MonoBehaviour
{
	public GameObject targetEnInfo;
	public float speed = 0.5f;

	private void Update()
    {
		FollowTarget();
	}

    void FollowTarget()
	{
		if (targetEnInfo != null)
		{
			Vector3 dir = targetEnInfo.transform.position - this.transform.position;

			this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(new Vector3(dir.x, dir.y, dir.z)), Time.deltaTime * speed);
		}
	}
}
