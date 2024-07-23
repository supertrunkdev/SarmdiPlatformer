using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rigidbody;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Vector3 temp = new Vector3(-10,0,0);
        rigidbody.useGravity = false;
        rigidbody.velocity = temp;
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ |
            RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >=1)
        {
            time = 0;
            Vector3 temp = rigidbody.velocity;
            temp.x *= -1;
            rigidbody.velocity = temp;
        }
    }
}
