using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProjectTest : MonoBehaviour
{

    public Transform Target;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        Vector3 distanceVector = Target.position - transform.position;
        
        Debug.Log(Vector3.Dot(transform.forward, distanceVector.normalized));
        
        Debug.DrawRay(transform.position, transform.forward * 5f,Color.blue);
        
        Debug.DrawRay(transform.position, distanceVector, Color.red);

        Vector3 normalVector = Vector3.Cross(transform.forward, distanceVector.normalized);

        Debug.DrawRay(transform.position, normalVector * 5f, Color.green);


        //normalVector.magnitude; // 벡터의 크기
        //normalVector.normalized; // 정규화된 벡터
        //normalVector.sqrMagnitude // 벡터의 크기^2
        //normalVector.x == normalVector[0]
        //normalVector.y == normalVector[1]
        //normalVector.z == normalVector[2]

        //Vector3.Angle(); // 두 벡터의 사이각
        //Vector3.Cross(); // Cross Product
        //Vector3.Dot(); // Dot Product
        //Vector3.Distance();// 두 벡터 사이의 거리 == distanceVector.magnitude 
        //Vector3.Max(); // 두 벡터 중 큰 크기를 가지는 벡터
        //Vector3.Min(); // 두 벡터 중 작은 크기를 가지는 벡터
        //Vector3.Normalize(); // 정규화 == Vector.Nomalized;
        //Vector3.Project(); // 한 쪽으로 사영한 벡터를 얻는다.
    
    
    }
}
