using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting up the Git guide.");
    }

    private void OnDisable()
    {
        Debug.Log("Stopping Git guide.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Detected a mouse click.");
        }
    }
}
