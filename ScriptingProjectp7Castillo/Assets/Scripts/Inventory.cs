using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bulll, int gre, int roc)
        {
            bullets = bulll;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        // Constructor
        public Stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myStuff.bullets);
    }
}
