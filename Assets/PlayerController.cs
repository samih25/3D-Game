using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float _sinir;
    [SerializeField] float _moveSpeed, _speed;
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime,0,_speed*Time.deltaTime));
        _sinir = transform.position.x;
        _sinir = Mathf.Clamp(_sinir, -4, +4);
        transform.position = new Vector3(_sinir, transform.position.y, transform.position.z);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
