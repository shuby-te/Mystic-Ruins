using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Si_BossAttack : MonoBehaviour
{
    public GameObject Gear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BossAttackType1()
    {
        Vector3 gearPos = transform.localPosition;
        gearPos.x += 3; 
        Instantiate(Gear, gearPos, Gear.transform.rotation);
    }
    void BossAttackType2()
    {

    }
    void BossAttackType3()
    {

    }
}
