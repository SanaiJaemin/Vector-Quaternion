using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logtest : MonoBehaviour // MonoBehaviour �� ��ӹް��־ �����Ͽ��� ����� �����Ѱ��̴�.
{
    public int Number;
    public float Number2;
    public bool Isnumber;
    public string str;
    public Rigidbody rb;



    class Person
    { 
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FullNmae
        {
            get
            {
                return $"{FirstName}{SecondName}";
            }
        }

    }






    public int number;
    // Start is called before the first frame update

    private void Awake()
    {
            Debug.Log($"Awake �ܰ迡�� �Ҵ�Ǿ����ϴ�. {rb.mass}");    
    }
    private void OnEnable()
    {
        Debug.Log($"OnEnable �ܰ迡�� �Ҵ�Ǿ����ϴ�. {rb.mass}");
    }

    void Start() // ��ũ��Ʈ�� ���� �ش� ������Ʈ�� ó������ ���� �Ǵ� �׼��� �̶� ������Ʈ Ȱ��ȭ ������ �� ���ʷ� 1ȸ ����ȴ�.
    {
        Debug.Log($"Start �ܰ迡�� �Ҵ�Ǿ����ϴ�. {rb.mass}");
        Person person = new Person();

        person.FirstName = "Jaemin";
        person.SecondName = "Kim";

        Debug.Log($"���� ���� �̸��� {person.FullNmae}");
        


    }


  
}
