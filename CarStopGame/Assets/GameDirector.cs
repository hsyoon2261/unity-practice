using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하는 데 필요하다.

public class GameDirector : MonoBehaviour
{
    private GameObject car;

    private GameObject flag;

    private GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        //Find메서드는 오브젝트 이름을 인수로 전달하고 인수 이름이 게임 씬 안에 있으면 해당 오브젝트를 반환합니다.
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        //F2 소수를 표시할 때 소수점 이하 자릿수를 조정한다 : F2 = 소숫점 두자리수까지. 버림.
        //D5 456=> 00456
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지" + length.ToString("F2") + "m";
        }
        else
            this.distance.GetComponent<Text>().text = "게임 오버!";
    }
}
