using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sample
{
    public class BossHP : EnemyHP
    {
        public GameObject sliderObj;
        public Slider slider;

        protected override void Awake()
        {
            base.Awake();

            slider.maxValue = MaxHP;
            slider.minValue = 0;
            slider.value = MaxHP;
            sliderObj.SetActive(true);
        }

        protected override void UpdateUI()
        {
            base.UpdateUI();
            slider.value = hp;
        }

        private void OnDisable()
        {
            sliderObj.SetActive(false);
        }
    }
}
