using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public static float MinX = -8;
    public static float MinY = -3;
    public static float MaxX = 8;
    public static float MaxY = 5;
}

public class PlayerMove : MonoBehaviour
{
    // 목표
    // 플레이어를 움직인다.
    // 방향 : 위아래,왼쪽 오른쪽 
    // 속도 : 방향 x 속력

    [Header("속성")]
    public float speed = 5; // 이동 속력


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, vertical, 0);
        dir.Normalize();

        transform.position = transform.position + dir * speed * Time.deltaTime;
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, Boundary.MinX, Boundary.MaxX);
        position.y = Mathf.Clamp(position.y, Boundary.MinY, Boundary.MaxY);

        transform.position = position;
    }




}