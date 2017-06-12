using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public string pointName;

    SpawnPoint()
    {
        if(pointName == null|| pointName == "")
        {
            pointName = "default";
        }
    }

    public void setName(string thisName)
    {
        this.pointName = thisName;
    }

    public string getName()
    {
        return this.pointName;
    }
}
