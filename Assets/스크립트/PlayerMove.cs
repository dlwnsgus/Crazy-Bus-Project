using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;  //차량 전진 속도 조절
    private float rotate = -1; //차량 차선 변경 값
    Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    { 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);//차량 전진
        if (Input.GetButtonDown("Horizontal"))//차량 회전 
        {
            rotate += -Input.GetAxisRaw("Horizontal");//rotate에 차량 좌우 움직이는 값 입력
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime*3); //차량 회전 복구
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, rotate), 5 * Time.deltaTime); //차량 좌우 이동

    }
}
