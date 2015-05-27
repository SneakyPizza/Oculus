using UnityEngine;
using System.Collections;

public class Bobbing : MonoBehaviour {
    public enum BobbingDirection
    {
        None,
        Up,
        Down
    }

    public float maxBobbing;
    public float minBobbing;
    public float bobbingSpeed;

    private float m_currentBobbing;
    private BobbingDirection m_direction;

    private void Start()
    {
        m_direction = BobbingDirection.Up;
    }

    private void Update()
    {

    }
}

