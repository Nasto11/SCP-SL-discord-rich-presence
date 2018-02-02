using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unixtime : MonoBehaviour {

	// Use this for initialization
	public void tak () 
	{
		 System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
 		 long cur_time = (long)(System.DateTime.UtcNow - epochStart).TotalSeconds;

	}
	
}
