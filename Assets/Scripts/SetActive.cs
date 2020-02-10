using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;

    private float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.activeSelf is true)
            time += Time.deltaTime;
        if (time > 3f)
        {
            obj.SetActive(false);
            time = 0;
        }
            
                }
}
