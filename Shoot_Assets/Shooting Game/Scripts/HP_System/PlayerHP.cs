using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : HP_System
{
    public GameObject[] lifeCount;

    protected override void Awake()
    {
        lifeCount = new GameObject[maxHP];
        for (int i = 0; i < maxHP; i++)
        {
            string s = "Image" + i;
            lifeCount[i] = GameObject.Find($"Canvas/HUD/{s}").gameObject;
        }
    }

    protected override void UpdateUI()
    {
        Debug.Log("ü�� UI ���� ����");

        for (int i = 0; i < lifeCount.Length; i++)
        {
            if (i < hp && !lifeCount[i].activeSelf) // ü�� Ȱ��ȭ
            {
                lifeCount[i].SetActive(true);
            }
            else if (i >= hp && lifeCount[i].activeSelf) // ü�� ��Ȱ��ȭ
            {
                lifeCount[i].SetActive(false);
            }
        }

    }
}
