using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveReplies : MonoBehaviour
{
	public GameObject[] ListofReplies;
	public GameObject[] ListofReplies2;

	//public int TotalReplies;

	void Start()
    {
		// Create an array of all the posts with the tag "PostPrefabTag"
		ListofReplies = GameObject.FindGameObjectsWithTag("ReplyTag");
		ListofReplies2 = GameObject.FindGameObjectsWithTag("ReplyTag2");

		foreach (GameObject ReplyTag in ListofReplies)
		{
			ReplyTag.SetActive(false);
		}

		foreach (GameObject ReplyTag2 in ListofReplies2)
		{
			ReplyTag2.SetActive(false);
			print("hi)");
		}

		//print(TotalReplies);
		//print(ListofReplies.Length);

	}

	void Update()
    {

	}
}
