using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelAction : MonoBehaviour
{
    delegate string deleg<T1, T2>(T1 a, T2 b);
    deleg<int, int> mydeleg;
    //���� ���� ���� �� Action
    Action<int, int> mydeleg2;
    //���� ���� ���� �� ���
    Func<int, int, string> mydeleg3;
    // Start is called before the first frame update
    void Start()
    {
        mydeleg3 = (int a, int b) => { int sum = a + b; return sum + "�� ���ϵǾ����ϴ�."; };

        print(mydeleg3(3, 5));
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
