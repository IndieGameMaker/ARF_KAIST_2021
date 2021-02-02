using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorCtrl : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    public float turnSpeed = 20.0f;
    public Vector3 movePos = Vector3.zero;
    public bool isMove = false;

    void Start()
    {
        
    }

    public void MoveWarrior(Vector3 pos)
    {
        movePos = pos;
        isMove = true;
    }

    void Update()
    {
        if (isMove == false) return;

        //목적지를 바라보는 벡터 계산 (목적지좌표 - 현재좌표)
        Vector3 dir = movePos - transform.position;
        //회전각도를 계산
        //회전처리 , 보간함수(선형보간 Lerp, 스피어리컬보간 Slerp)
        //직진이동
    }
}
