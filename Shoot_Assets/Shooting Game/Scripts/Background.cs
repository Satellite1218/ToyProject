using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Background : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public Material bgMat;
        public float scrollSpeed = 0.2f;
        public Vector2 dirVec = Vector2.zero;

        // Update is called once per frame
        void Update()
        {
            // �̵����� * �ӷ� * �ð�
            Vector2 direction = dirVec; //Vector2.up; // ��,��(�밢�� ��)
            bgMat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;  
        }
    }
}
