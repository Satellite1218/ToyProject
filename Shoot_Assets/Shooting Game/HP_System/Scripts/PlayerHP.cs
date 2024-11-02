using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class PlayerHP : HP_System
    {
        public GameObject[] lifeCount;

        protected override void Awake()
        {
            base.Awake();
            lifeCount = new GameObject[MaxHP];

            for (int i = 0; i < MaxHP; i++)
            {
                string s = "Image" + i;
                lifeCount[i] = GameObject.Find($"Canvas/HUD/{s}").gameObject;
            }
        }

        protected override void UpdateUI()
        {
            base.UpdateUI();
            for (int i = 0; i < lifeCount.Length; i++)
            {
                if (i < hp && !lifeCount[i].activeSelf) // 체력 활성화
                {
                    lifeCount[i].SetActive(true);
                }
                else if (i >= hp && lifeCount[i].activeSelf) // 체력 비활성화
                {
                    lifeCount[i].SetActive(false);
                }
            }
        }
    }
}
