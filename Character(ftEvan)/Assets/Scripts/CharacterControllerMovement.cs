using UnityEngine;

public class CharacterControllerMovement : MonoBehaviour
{
    public float speed = 10f;
    private CharacterController characterController;
    private Transform myTransform;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        myTransform = transform;
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        characterController.SimpleMove(direction * speed);

        if (direction != Vector3.zero)
        {
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(direction), 0.15f);
        }
    }
}
