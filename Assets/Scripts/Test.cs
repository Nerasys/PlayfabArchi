using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public AccountData accountData;
    // Start is called before the first frame update
    void Start()
    {
        accountData.idPlayfab = "coucou";
    }

    // Update is called once per frame
    int i = 0 ;
    void Update()
    {
        i++;
           accountData.idPlayfab =i.ToString() ;
    }
}
