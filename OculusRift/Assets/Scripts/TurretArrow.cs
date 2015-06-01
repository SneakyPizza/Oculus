using UnityEngine;
using System.Collections;

public class TurretArrow :  Projectile {
	


	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.position = new Vector3 (0, 0, 0);
	}
}
