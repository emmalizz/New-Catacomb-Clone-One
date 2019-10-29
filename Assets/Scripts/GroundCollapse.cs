using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollapse : MonoBehaviour
{

	private float currentTime;
	private bool collapse;
	public List<Transform> childrenList;

    // Start is called before the first frame update
    void Start()
    {
		int i = 0;
		foreach (Transform child in transform)
		{
			childrenList[i] = child;
			++i;
		}
    }

    // Update is called once per frame
    void Update()
    {
		currentTime += Time.deltaTime;
		if ((int)currentTime % 3 == 0) collapse = true;
        if (collapse == true && (int) currentTime % 3 != 0)
		{
			collapse = false;
			collapseGround(); 
		}
    }

	void collapseGround()
	{
		childrenList[0].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
		shiftUp(childrenList);
	}

    void shiftUp(List<Transform> list)
	{
        for (int i = 1; i < numberOfChildren(); ++i)
		{
			list[i - 1] = list[i];
		}
	}

    int numberOfChildren()
	{
		int len = 0;
		foreach (Transform child in childrenList)
			if (child != null)
                len++;
		return len;
    }
}
