using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollapse : MonoBehaviour
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
        if (collapse == true && (int)currentTime % 3 != 0)
        {
            collapse = false;
            collapseWall();
        }
    }

    void collapseWall()
    {
        print(childrenList);

        float columnX = childrenList[0].transform.position.x;
        int i = 0;
        while (childrenList[i].transform.position.x == columnX)
        {
            childrenList[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            ++i;
       }
       shiftUp(childrenList, i);
    }

    void shiftUp(List<Transform> list, int numToShift)
    {
        int a = 0;
        for (int i = numToShift; i < numberOfChildren(); ++i)
        {
            list[a] = list[i];
            ++a;

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
