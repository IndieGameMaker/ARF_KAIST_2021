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
        
    }
}
