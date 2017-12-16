using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //declaring the position variables that the platform will move between
    private Vector3 pos1;
    private Vector3 pos2;
    //declaring the speed variable
    private float speed = 8;
    //declairng the variable to see which position is next
    private Vector3 NextPos;
    //declaring a variables and showing it in the inspector in unity to transform the obstacle
    [SerializeField]
    private Transform TransChild;
    [SerializeField]
    private Transform Trans2;

    // Use this for initialization
    void Start()
    {

        pos1 = TransChild.localPosition;
        pos2 = Trans2.localPosition;
        NextPos = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //this function will move the platform up and down
    private void Move()
    {
        TransChild.localPosition = Vector3.MoveTowards(TransChild.localPosition, NextPos, speed * Time.deltaTime);
        if (Vector3.Distance(TransChild.localPosition, NextPos) <= 0.1)
        {
            ChangePos();
        }
    }

    //alternates between the positions that the moving obstacle has to travel to
    private void ChangePos()
    {
        NextPos = NextPos != pos1 ? pos1 : pos2;
    }
}
