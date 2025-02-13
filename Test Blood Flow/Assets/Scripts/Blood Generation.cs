using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodGeneration : MonoBehaviour
{
    [SerializeField] GameObject _blood;
    [SerializeField] bool _cuted;
    [SerializeField] float compteur = 0;
    [SerializeField] float timer = 1f;
    [SerializeField] float Strengh = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_cuted)
        {
            BloodSpawn();
        }
        
    }
    void BloodSpawn()
    {
        
        compteur += Time.deltaTime;
        if(compteur>timer)
        {
            if(this.transform.childCount<20)
            {
                compteur = 0;
                GameObject temp =Instantiate(_blood,this.transform);
                Rigidbody blood = temp.GetComponent<Rigidbody>();
                blood.AddForce(new Vector3(-1, 0, 0)*Strengh);

            }
        }


    }
   

}
