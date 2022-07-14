using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logtest : MonoBehaviour // MonoBehaviour 을 상속받고있어서 유닡니에서 사용이 가능한것이다.
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
            Debug.Log($"Awake 단계에선 할당되었습니다. {rb.mass}");    
    }
    private void OnEnable()
    {
        Debug.Log($"OnEnable 단계에선 할당되었습니다. {rb.mass}");
    }

    void Start() // 스크립트가 붙은 해당 오브젝트가 처음으로 생성 되는 그순간 이랑 오브젝트 활성화 상태일 때 최초로 1회 실행된다.
    {
        Debug.Log($"Start 단계에선 할당되었습니다. {rb.mass}");
        Person person = new Person();

        person.FirstName = "Jaemin";
        person.SecondName = "Kim";

        Debug.Log($"나의 영어 이름은 {person.FullNmae}");
        


    }


  
}
