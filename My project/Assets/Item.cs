using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string name;
    private int STR, DEX, INT, LUK;



    // Start is called before the first frame update
    void Start()
    {

    }

    public Item(string _name, int _STR, int _DEX, int _INT, int _LUK)
    {
        this.name += _name;
        this.STR += _STR;
        this.DEX += _DEX;
        this.INT += _INT;
        this.LUK += _LUK;
    }
    public void Show()
    {
        Debug.Log(name);
        Debug.Log(STR);
        Debug.Log(DEX);
        Debug.Log(INT);
        Debug.Log(LUK);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
