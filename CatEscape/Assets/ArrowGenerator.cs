using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //arrowPrefab = 여기에 연결된 인스턴스(아까만든 arrow) 설계도. 
    public GameObject arrowPrefab;

    private float span = 0.5f; //60fps = 1초
    private float delta = 0; 
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //1fps
        if (this.delta > this.span) // delta>span
        {
            this.delta = 0; //delta 초기화
            //화살 인스턴스 생성
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
