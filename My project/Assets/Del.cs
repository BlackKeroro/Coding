using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Del : MonoBehaviour
{
    Dictionary<string, Item> itemMap;

    string _name;

    Item item;
    // Start is called before the first frame update
    void Start()
    {
        itemMap = new Dictionary<string, Item>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            name = "�����ũ��";
            itemMap.Add(_name, new Item(_name, 20, 40, 30, 40));
            item.Show();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

           bool result = itemMap.Remove("�����ũ��");
            if (result)
            {
                Debug.Log("�����ũ�� ����");
                item.Show();
            }
        }
    }

    private void OnDisable()
    {
        
    }
}
