using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1. 위치 벡터
//2. 방향 벡터
public class PlayerController : MonoBehaviour
{
    //private이어도 serializefield attibute 를 붙여주면 유니티 에디터에서 수정가능하다.
    [SerializeField] private float _speed = 10.0f;

    void Start()
    {
        Managers.input.KeyAction -= OnKeyboard; //혹시 이미 구독중인 이벤트 있으면 해지하고 시작
        Managers.input.KeyAction += OnKeyboard;
    }

    void Update()
    {
    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);


            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}


//_yAngle += Time.deltaTime * 100.0f;
//transform.Rotate(new Vector3(0.0f,_yAngle,0.0f));
//transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
//Local -> World
// TransformDirection
//World -> Local
// InverseTransformDirection
//slerp : param a, b 의 반영 비율 넣어서 부드럽게
//quaternion.lookrotation
//내 기준으로 앞으로 한칸 => 하지만 transform.position은 월드 좌표 기준이므로 이 로컬 희망좌표를 월드 좌표로 변환하여서 화면에 띄워줌.
//transform.position += transform.TransformDirection(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * _speed);
//예약된 키워드 사용시(ex Vector3.forward)
//player 기준으로 연산하고 싶을 땐
//transform.Translate(Vector3.forward*Time.deltaTime*_speed);
//보통의 접근방식
//GameObject(Player)
//TransForm
//PlayerController(*)