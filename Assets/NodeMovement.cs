using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{

    [SerializeField] public Transform _connectedNode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.position= new Vector3(Mathf.Lerp(transform.position.x,_connectedNode.position.x,Time.deltaTime*5),_connectedNode.position.y,_connectedNode.position.z+2);
    }
}
