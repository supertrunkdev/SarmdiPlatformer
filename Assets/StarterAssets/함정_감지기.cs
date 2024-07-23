using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 함정_감지기 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("들어왔습니다.");
        Debug.Log(other.gameObject.tag);
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("나갔습니다.");
    }
}
