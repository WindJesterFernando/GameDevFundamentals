using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    [SerializeField] private float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // for (int i = 0; i < 1000; i++)
        // {
        //     Debug.Log("asdsadfsad");
        // }

        Vector3 pos = transform.position;
        float scrollAmount = scrollSpeed * Time.deltaTime;
        pos.x -= scrollAmount;

        if (pos.x <= -7.63f)
        {
            pos.x += (24.37f + 7.63f);
        }


        transform.position = pos;
    }
}

