using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : EnemyHP
{
    public GameObject obj;
    public Slider slider;

    protected override void Awake()
    {
        base.Awake();

        slider.maxValue = maxHP;
        slider.minValue = 0;
        slider.value = maxHP;
        obj.SetActive(true);
    }

    protected override void UpdateUI()
    {
        base.UpdateUI();
        slider.value = hp;
    }

    private void OnDisable()
    {
        obj.SetActive(false);
    }
}
