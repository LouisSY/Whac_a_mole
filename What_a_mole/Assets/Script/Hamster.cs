using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamster : MonoBehaviour
{

    public GameObject mouse_leave_prefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnMouseDown() {
        Debug.Log("Click!");
        Destroy(gameObject);
        Instantiate(mouse_leave_prefab, transform.position, Quaternion.identity);
    }
}
