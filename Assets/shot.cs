using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Ray ray;
    RaycastHit hit;
    public LayerMask layer;

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        if(Physics.Raycast(ray,out hit, 50, layer))
        {
            if (Input.GetMouseButtonDown(0)){
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
