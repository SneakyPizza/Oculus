using UnityEngine;
using System.Collections;

public class TurretArrow :  Projectile {
	


	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward * _speed * Time.deltaTime);
	}
}
