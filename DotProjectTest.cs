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


        //normalVector.magnitude; // ������ ũ��
        //normalVector.normalized; // ����ȭ�� ����
        //normalVector.sqrMagnitude // ������ ũ��^2
        //normalVector.x == normalVector[0]
        //normalVector.y == normalVector[1]
        //normalVector.z == normalVector[2]

        //Vector3.Angle(); // �� ������ ���̰�
        //Vector3.Cross(); // Cross Product
        //Vector3.Dot(); // Dot Product
        //Vector3.Distance();// �� ���� ������ �Ÿ� == distanceVector.magnitude 
        //Vector3.Max(); // �� ���� �� ū ũ�⸦ ������ ����
        //Vector3.Min(); // �� ���� �� ���� ũ�⸦ ������ ����
        //Vector3.Normalize(); // ����ȭ == Vector.Nomalized;
        //Vector3.Project(); // �� ������ �翵�� ���͸� ��´�.
    
    
    }
}
