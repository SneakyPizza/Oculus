using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WeaponSwitch : MonoBehaviour 
{
	[SerializeField] private GameObject _Player;

	private int _currentWeapon;

<<<<<<< HEAD
	List<GameObject> AbilitiesL = new List<GameObject> ();

	void Lists()
	{
		//AbilitiesL.Add (FireBall);
		//AbilitiesL.Add (FlameThrower);
	}

	// Use this for initialization
	void Start () 
	{
		Lists ();
	}
=======
	[SerializeField] List<GameObject> AbilitiesL = new List<GameObject> ();
>>>>>>> 40dccd0e5a7ddab5ca2fc1b01aec820d3ba57065
	

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
