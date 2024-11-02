using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_System : MonoBehaviour
{
    [SerializeField] protected int hp;     //����ü��
    public int maxHP;   //�ִ�ü��

    public int HP
    {
        get { return hp; }
        set
        {
            hp = value; //HP���� value�� ����

            if (hp >= maxHP)
            {
                hp = maxHP;  //�ִ� ü���� ���� ���ϰ�
            }

            if (hp <= 0)
            {
                hp = 0; //ü���� ������ �������� �ʰ�
            }

            UpdateUI();        //HP����� ü�� UI ����
        }
    }

    protected virtual void Awake()
    {
        
    }

    protected virtual void UpdateUI()
    {

    }

    public void DecreaseHP(int dmage = 1)
    {
        HP -= dmage;
    }

    public void IncreseHP(int value = 1)
    {
        HP += value;
    }

    public bool isDead()
    {
        return HP <= 0 ? true : false;
    }

    private void Start()
    {
        hp = maxHP;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            DecreaseHP();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            IncreseHP();
        }
    }
}
