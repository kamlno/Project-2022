using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    GameObject Target;
    private float MaxTimer;
    private float LocationTimer;
    GameObject DustSmoke_A;
    GameObject Spikes_attack;
    //private Queue<GameObject> SpikeContainer;
    // Start is called before the first frame update
    void Start()
    {
        //SpikeContainer = new Queue<GameObject>();
        //SpikeContainer.Enqueue(gameObject);
        Target = GameObject.Find("Character(Clone)");
        gameObject.transform.position = Target.transform.position;
        MaxTimer = 0;
        DustSmoke_A = transform.Find("DustSmoke_A").gameObject;
        Spikes_attack = transform.Find("Spikes_attack").gameObject;
        LocationTimer = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        MaxTimer += Time.deltaTime;
        //LocationTimer += Time.deltaTime;
        if(MaxTimer > 0.5)
        {
            DustSmoke_A.SetActive(false);
            Spikes_attack.SetActive(true);
        }
        if (MaxTimer > 1.8)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
        //if(LocationTimer)
        {
            //gameObject.transform.position = Target.transform.position;
            //LocationTimer = Time.time + 100;
        }
    }
}
