using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI를 사용하므로 잊지 않고 추가한다.

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    // ui 갱신하는 감독
    private GameObject hpGauge;
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
