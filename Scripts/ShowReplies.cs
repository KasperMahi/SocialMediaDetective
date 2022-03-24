using UnityEngine;


public class ShowReplies : MonoBehaviour
{

	public GameObject[] ListofPosts;
	public RemoveReplies removeReplies;

	public void Start()
	{
		// Create an array of all the posts with the tag "PostPrefabTag"
		ListofPosts = GameObject.FindGameObjectsWithTag("PostPrefabTag");

	}



	public void HandleInput()
	{
		//gameObject.SetActive(!gameObject.activeSelf);


		// loop through all posts, if they are active when button is clicked, set them to inactive
		foreach (GameObject PostPrefabTag in ListofPosts)
		{

			if (PostPrefabTag.activeSelf)
			{
				PostPrefabTag.SetActive(false);

				foreach (GameObject ReplyTag2 in removeReplies.ListofReplies2)
				{
					ReplyTag2.SetActive(true);
					//print("showing");
				}

			}
			else
			{
				PostPrefabTag.SetActive(true);

				foreach (GameObject ReplyTag2 in removeReplies.ListofReplies2)
				{
					ReplyTag2.SetActive(false);
					//print("hiding");
				}
			}

			//PostPrefabTag.SetActive(!PostPrefabTag.activeSelf);
		}

		// set the post/gameobject the button is on to active if isnt
		if (!gameObject.activeSelf)
		{
			gameObject.SetActive(true);
		}

	}
}
