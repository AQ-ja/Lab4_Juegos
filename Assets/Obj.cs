using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    public float fuerza = 1;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        

        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
               
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    Rigidbody rb;
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        AlCielo(rb);
                        PrintName(hit.transform.gameObject);
                    }
                }
            }
        }
    }
    private void PrintName(GameObject objeto)
    {
        print(objeto.name);

    }
    private void AlCielo(Rigidbody rig)
    {
        rig.AddForce(rig.transform.forward * fuerza, ForceMode.Impulse);


    }
}
