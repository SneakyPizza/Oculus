using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 50f;
    public float rotationSpeed = 35f;
    public float maxHeight = 55;
    public float minHeight = 10;
    public float maxY = 60f;
    public float minY = -60f;
    public bool enableRightJoystick;

    private Vector3 m_velocity;
    private Vector3 m_rotationVelocity;
    private float rotationY = 0f;

    private void Start()
    {
        m_velocity = new Vector3(0, 0, 0);
        m_rotationVelocity = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        //movment
        m_velocity = Vector3.zero;

        m_velocity.x = (Input.GetAxis("Horizontal") * movementSpeed) * Time.deltaTime;
        m_velocity.z = (Input.GetAxis("Vertical") * movementSpeed) * Time.deltaTime;
        m_velocity.y = ((Input.GetAxis("Triggers") * -1) * movementSpeed) * Time.deltaTime;

        if(m_velocity.y + transform.parent.position.y > maxHeight)
        {
            m_velocity.y = maxHeight - transform.parent.position.y;
        }
        if(m_velocity.y + transform.parent.position.y < minHeight)
        {
            m_velocity.y = minHeight - transform.parent.position.y;
        }

        m_velocity = transform.parent.transform.TransformDirection(m_velocity);

        transform.parent.position += m_velocity;
        //rotation
        if(enableRightJoystick)
        {
            m_rotationVelocity.y = Input.GetAxis("RightStickHorizontal");
            m_rotationVelocity.x = Input.GetAxis("RightStickVertical");

            Vector2 camRotation = new Vector2(0, 0);

            float rotationX = transform.parent.transform.localEulerAngles.y + (Input.GetAxis("RightStickHorizontal") * rotationSpeed) * Time.deltaTime;

            rotationY += (Input.GetAxis("RightStickVertical") * rotationSpeed) * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.parent.transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);
        }
    }
}
