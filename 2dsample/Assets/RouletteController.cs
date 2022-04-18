using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotSpeed = 0;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정한다.
        //GetMouseButtonDown : 클릭순간 true 반환
        //GetMouseButton : 누르고 있는 동안 true반환
        //GetMouseButtonUp : 손가락을 뗀 순간 true반환
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 20;
        }
        // 회전 속도만큼 룰렛을 회전시킨다. Rotate 메서드는 오브젝트를 회전시킨다. 
        // 회전값이 양수면 시계 반대방향, 음수면 시계 방향으로 회전합니다.
        transform.Rotate(0,0,this.rotSpeed);
        
        //회전속도 줄이기. 감쇠 매커니즘 적용
        this.rotSpeed *= 0.97f;

    }
}
