using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Player"); //플레이어를 찾아서 객체에 지정
    }

    void Update()
    {
        Vector3 PlayerPos = player.transform.position; // 플레이어가 조종중인 게임 오브젝트의 위치를 계산
        transform.position = new Vector3(PlayerPos.x-7.248f, transform.position.y, transform.position.z); // 플레이어가 조종중인 오브젝트의 y 값만 카메라의 좌표에 넘김
    }
}