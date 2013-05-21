using UnityEngine;
using System.Collections;

public class RedHornBeastTrigger : MonoBehaviour
{
	/**/
	void OnTriggerEnter(Collider other) 
	{
		// Make the beast appear...
		if ( other.tag == "Player" )
		{
			transform.parent.gameObject.SendMessage("Appear");
		}
    }

	/* Use this for initialization */
	void Start ()
	{
	
	}
	
	/* Update is called once per frame */
	void Update ()
	{
		
	}
}
