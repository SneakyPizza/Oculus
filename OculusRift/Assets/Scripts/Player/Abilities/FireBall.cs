using UnityEngine;
using System.Collections;

public class FireBall : Projectile
{
	void Update () 
	{
		_lifeTime -= 1 * Time.deltaTime;
		transform.Translate(Vector3.forward * _speed * Time.deltaTime);

		if (_lifeTime <= 0f) 
		{
			GameObject.Destroy();
		}
	}

	void OnCollisionEnter(Collider col)
	{
		if (col.tag = "Castle") 
		{
			GameObject.Destroy();
		}
	}
}
