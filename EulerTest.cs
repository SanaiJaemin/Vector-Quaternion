using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerTest : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float x;
    // Update is called once per frame
    void Update()
    {
        /*Quaternion rot = transform.rotation;*/ // 4가지 원소의 각 x,y,z,w 각도 
        //rot.x += Time.deltaTime * 1;
        //transform.rotation = rot;
        //Vector3 anles = transform.rotation.eulerAngles;
        //anles.x += Time.deltaTime * 10;
        //transform.rotation = Quaternion.Euler(anles);

        x += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, x, 0); //<== 이게 최고 좋은 방법 


    }
}
