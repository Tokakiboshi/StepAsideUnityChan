using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyControler : MonoBehaviour
{
    // Start is called before the first frame update
        GameObject mainCamObj;


    void Start()
    {
            mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamObj.transform.position.z>gameObject.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
