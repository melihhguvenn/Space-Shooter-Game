using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    // Update is called once per frame
    void Update()
    {
        Move();

        if (transform.position.y > 7.1f) {
        Destroy();
        }
    }

    void Move()
    {
        Vector3 direction = Vector3.up;
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    void Destroy() {
        Destroy(this.gameObject);
    }
}
