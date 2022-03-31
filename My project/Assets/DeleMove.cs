using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DeleMove : MonoBehaviour
{
    Action<int, int, int> deleg1;
    Func<int, int, string> deleg2;

    public GameObject TextUI;
    public GameObject txtParent;
    TextMeshProUGUI txt;

    int Level = 0;
    int STR = 0;
    int Power = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject a = Instantiate(TextUI, transform.position, transform.rotation);
            a.transform.SetParent(txtParent.transform, false);
            int Ra = UnityEngine.Random.Range(4, 8);
            int Rb = UnityEngine.Random.Range(1, 9);
            deleg2 = (int _a, int b) => { int sum = _a* + b; return sum.ToString(); };
            txt = a.GetComponent<TextMeshProUGUI>();
            txt.text = deleg2(Ra, Rb);

        }
        if (Input.GetButtonDown("0"))
        {
            //deleg1 = (int _Level, int _STR, int _Power) => { int Level += _Level, STR += _STR, Power += _Power; };

            deleg1(1, 3, 5);
            
        }
    }
}
