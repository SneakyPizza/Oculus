using UnityEngine;
using System.Collections;

public class PlayerHtbox : MonoBehaviour {

    private HealthContainer m_health;

    private void Start()
    {
        m_health = GetComponent<HealthContainer>();
    }

	public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TurretArrow>())
        {
            m_health.DealDamage(other.GetComponent<TurretArrow>().Damage);
        }
    }
}
