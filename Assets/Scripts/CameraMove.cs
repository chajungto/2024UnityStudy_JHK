using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 offset;

    public GameObject playerPosition;


    //Ű�޶�� �÷��̾�� �׻� ���� �Ÿ� ����

    //�÷��̾��� ��ġ���� �ʿ� 

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
