using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Range(10F, 60F)]
    private float moveSpeed = 10F;

    [SerializeField]
    [Range(30F, 60F)]
    private float rotationSpeed = 30F;

    [SerializeField]
    [Range(1F, 20F)]
    private float jumpForce = 1F;

    private float vVal;
    private float hVal;

    private Rigidbody myRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}