using UnityEngine;
using System.Collections;
using System;

public class CSharpTut : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Variables myClass;
        myClass = new Variables();

        myClass.Test();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class Variables
{
    public void Test()
    {
        int x = 100;
        int y;
        y = 150;

        int z;

        z = x + y;

        Debug.Log( String.Format( "{0}", z ) );

        string Name = "Joe";
        string Surname = "Schmoe";

        Debug.Log(Name + " " + Surname);
        Debug.Log(String.Concat( Name, " ", Surname));

    }
}
