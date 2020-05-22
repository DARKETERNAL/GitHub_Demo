using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Range(10F, 60F)]
    private float moveSpeed = 10F;

    private float vVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vVal = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * vVal * moveSpeed * Time.deltaTime);
    }
}
