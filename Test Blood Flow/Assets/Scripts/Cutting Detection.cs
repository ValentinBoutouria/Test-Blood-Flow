using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CuttingDetection : MonoBehaviour
{
    [SerializeField] GameObject _bloodGenerators;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Arm")
        {

            foreach (ContactPoint contact in collision.contacts)
            {
                Vector3 pointDeContact = contact.point;
                GameObject temp = Instantiate(_bloodGenerators);
                temp.transform.position = pointDeContact;
                Debug.Log("Point de contact: " + pointDeContact);
            }
        }
    }
}
