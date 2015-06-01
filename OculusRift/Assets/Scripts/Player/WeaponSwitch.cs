using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WeaponSwitch : MonoBehaviour 
{
	[SerializeField] private GameObject _Player;

	private int _currentWeapon;

	[SerializeField] List<GameObject> AbilitiesL = new List<GameObject> ();
	

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.JoystickButton0)) //Flamethrower
		{
			GameObject.Instantiate(AbilitiesL[0],_Player.transform.position, _Player.transform.rotation);
		}

		if(Input.GetKeyDown(KeyCode.JoystickButton1)) //Fireball
		 {
			GameObject.Instantiate(AbilitiesL[1], _Player.transform.position, _Player.transform.rotation);
		}
	}
	
}
