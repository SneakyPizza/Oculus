using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthContainer : MonoBehaviour {

    public int startingHitPoints;
    public Image greenBar;

    private float _barMaxWidth;
    private int _hitPoints;
    
    private void Start()
    {
        _hitPoints = startingHitPoints;
        _barMaxWidth = greenBar.rectTransform.rect.width;
    }

    public void DealDamage(int dmg)
    {
        _hitPoints -= dmg;
        greenBar.rectTransform.sizeDelta = new Vector2((((float)_hitPoints / startingHitPoints) * _barMaxWidth), greenBar.rectTransform.sizeDelta.y);
        if(_hitPoints <= 0)
        {
            Die();
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F))
        {
            DealDamage(12);
        }
    }

    private void Die()
    {

    }
}
