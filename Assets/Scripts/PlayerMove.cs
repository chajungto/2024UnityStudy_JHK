using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 10.0f;
    public Vector3 direction = new Vector3();

    public bool IsRigidbody;

    void Update()
    { 
        if(IsRigidbody) Move();
        else RigidbodyMove();
    }

    private void Move()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    float dirValue = 1;
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    float dirValue = -1;
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    float dirValue = 1;
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    float dirValue = -1;
        //}


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);

        this.gameObject.transform.position = gameObject.transform.position + MoveSpeed * dir * Time.deltaTime;
    }

    // rigidbody 컴포넌트를 읽어올 방법없음
    // 컴포넌트들을 클래스에 가져와서 사용

    public Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void RigidbodyMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);

        rigidbody.velocity = dir * MoveSpeed * Time.deltaTime;
    }

}
