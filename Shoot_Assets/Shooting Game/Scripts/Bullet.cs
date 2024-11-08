using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Bullet : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;

        // 방향 x speed x time.deltaTime

        // Update is called once per frame
        void Update()
        {
            // 방향
            Vector3 dir = Vector3.up;
            transform.position = transform.position + dir * speed * Time.deltaTime;
        }
    }
}
