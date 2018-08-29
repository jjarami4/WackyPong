using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A paddle
/// </summary>
public class Paddle : MonoBehaviour
{
    //variables
    Rigidbody2D RB2D;
	
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        //attaches rigidbody to object
        RB2D = gameObject.AddComponent<Rigidbody2D>();

    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		
	}
	
}
