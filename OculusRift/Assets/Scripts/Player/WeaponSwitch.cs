using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WeaponSwitch : MonoBehaviour 
{
	[SerializeField] private GameObject _Player;

	private int _currentWeapon;

	List<GameObject> AbilitiesL = new List<GameObject> ();

	void Lists()
	{
		AbilitiesL.Add (FireBall);
		AbilitiesL.Add (FlameThrower);
	}

	// Use this for initialization
	void Start () 
	{
		Lists ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.A))
		{

		}
	
	}
}
