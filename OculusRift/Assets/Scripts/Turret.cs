using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Turret : MonoBehaviour 
{
	private float _Distance;

	[SerializeField] private GameObject _Turret;
	[SerializeField] private GameObject _Player;


	[SerializeField]private GameObject _turretArrow;
	
	List<GameObject> ProjectileL = new List<GameObject> ();
	
	void Lists()
	{
		ProjectileL.Add(_turretArrow);
	}

	void Start()
	{
		Lists ();
	}

	void Update()
	{
		_Distance = Vector3.Distance(transform.position,_Player.transform.position);

		if (_Distance <= 100) 
		{
			_Turret.transform.LookAt(_Player.transform);
			Shoot();
		}
	}

	void Shoot()
	{
		Debug.Log ("pew");
		GameObject.Instantiate(ProjectileL[Random.Range (0, ProjectileL.Count - 1)], _Turret.transform.position,_Turret.transform.rotation);
	}


}
