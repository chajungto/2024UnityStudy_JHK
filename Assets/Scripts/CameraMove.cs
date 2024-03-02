using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 offset;

    public GameObject playerPosition;


    //키메라는 플레이어와 항상 같은 거리 유지

    //플레이어의 위치정보 필요 

    void Start()
    {
        offset = transform.position - playerPosition.transform.position;   
    }

    void Update()
    {
        transform.position = playerPosition.transform.position + offset;
        offset = transform.position - playerPosition.transform.position;
    }
}
