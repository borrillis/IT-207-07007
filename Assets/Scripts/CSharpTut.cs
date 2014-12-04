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

        if ( /*condition*/ z <= 200 )
        { /* true part */
            Debug.Log("Z is less than 200");
        }
        else
        { /* false part */
            Debug.Log(" Z is greater than 200");
        }

        Debug.Log( (z >= 150) ? "Z is greater than 150" : " Z is less than 150");

        for ( /* initializer */ int i = 0 ; /* condition */ i < 10 ; /*increment*/ i++  )
        {
            /* statements */
            Debug.Log(i);
        }

        for (int i =10; i > 0; i--)
        { Debug.Log(i); }

        /* Pre-condition while */
        /* execute 0-* */
        bool isLooping = true;
        int counter = 0;
        while ( /* condition */  isLooping)
        {
            /* loop body */
            Debug.Log(counter++);
            isLooping = counter <= 100;
        }
    }
}
