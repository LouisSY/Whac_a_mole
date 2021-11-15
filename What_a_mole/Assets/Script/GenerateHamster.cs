using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHamster : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generateTarget", 0f, 1f);
        
    }

    void generateTarget() {
        int i = 0;
        Vector3 position = Vector3.zero;

        i = Random.Range(0, 15);
        switch(i) {
            case 0:
                position = new Vector3(0, 0, 0);
                break;
            case 1:
                position = new Vector3(2, 0, 0);
                break;
            case 2:
                position = new Vector3(-2, 0, 0);
                break;
            case 3:
                position = new Vector3(0, 2, 0);
                break;
            case 4:
                position = new Vector3(0, -2, 0);
                break;
            case 5:
                position = new Vector3(-2, -2, 0);
                break;
            case 6:
                position = new Vector3(-2, 2, 0);
                break;
            case 7:
                position = new Vector3(2, -2, 0);
                break;
            case 8:
                position = new Vector3(2, 2, 0);
                break;
            case 9:
                position = new Vector3(4, -2, 0);
                break;
            case 10:
                position = new Vector3(-4, 2, 0);
                break;
            case 11:
                position = new Vector3(-4, 0, 0);
                break;
            case 12:
                position = new Vector3(-4, -2, 0);
                break;
            case 13:
                position = new Vector3(4, 2, 0);
                break;
            case 14:
                position = new Vector3(4, 0, 0);
                break;
            default:
                break;        
        }
        Instantiate(target, position, Quaternion.identity);

    }
}
