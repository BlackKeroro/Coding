using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

delegate void DelegEvent();

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    public void Start()
    {
        Main();

    }
    static void handler()
    {
        Debug.Log("วฺต้");
    }

    static void Main()
    {
        EventDeleg N = new EventDeleg();
        N.Deleg += handler;
        N.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
class EventDeleg
{
    public event DelegEvent Deleg;

    public void Start()
    {
        if (Deleg != null)
        {
            System.Threading.Thread.Sleep(3000);
            Deleg();
        }
    }
    

}
