using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	[SerializeField]protected float _lifeTime = 20;	//base lifespan
	[SerializeField]protected int _dmg = 10;		//base dmg
	[SerializeField]protected float _speed = 25;	//base speed

<<<<<<< HEAD
	[SerializeField]protected int _dmg = 10;
	[SerializeField]protected float _speed = 5;

    public int Damage
    {
        get
        {
            return _dmg;
        }
    }
=======
>>>>>>> 40dccd0e5a7ddab5ca2fc1b01aec820d3ba57065
}
