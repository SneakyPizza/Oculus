using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	//[SerializedField]public int _dmg = 10;
	//[SerializedField]public int _speed = 5;

	[SerializeField]protected int _dmg = 10;
	[SerializeField]protected float _speed = 5;

    public int Damage
    {
        get
        {
            return _dmg;
        }
    }
}
