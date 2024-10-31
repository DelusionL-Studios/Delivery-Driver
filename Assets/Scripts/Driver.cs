using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0f;
    [SerializeField] float movementSpeed = 0f;

    void Update()
    {
        Move();
        Turn();
    }

    void Move()
    {
        var movementInput = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, movementInput, 0);
    }

    void Turn()
    {
        var turnInput = Input.GetAxis("Horizontal") * -turnSpeed * Time.deltaTime;
        transform.Rotate(0, 0, turnInput);
    }
}
