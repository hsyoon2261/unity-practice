using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;  //유일성이 보장된다. 싱글톤 패턴
    private static Managers Instance
    { get { Init(); return s_instance; } }

    private InputManager _input = new InputManager();
    public static InputManager input { get { return Instance._input; } }

    // Start is called before the first frame update
    void Start() { Init(); }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers"); //일단 매니저스라는 게임오브젝트를 찾는다.
            if (go == null) //못찾아서 go 아직 null인 경우
            {
                go = new GameObject {name = "@Managers"}; // 매니저스라는 이름으로 게임 오브젝트 생성
                go.AddComponent<Managers>(); //Managers라는 component를 붙인다.(바로 이 스크립트)
            }

            //삭제방지
            DontDestroyOnLoad(go);

            s_instance = go.GetComponent<Managers>();
        }
    }
}