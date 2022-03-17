using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    //public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _calculateMovement();
    }

    private void _calculateMovement(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0));
        if(transform.position.x > 11.3f){
            transform.position = new Vector3(-11.3f, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -11.3f){
            transform.position = new Vector3(11.3f, transform.position.y, transform.position.z);
        }
    }
}
