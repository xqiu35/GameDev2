using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDistributor : MonoBehaviour {

    public int number;
    [Range(1, 100)]
    public int areaSize = 1;
    public float offSet = 1;
    public GameObject targetObject;

    public void setNumber(int number)
    {
        this.number = number;
    }

    public void setOffset(int offSet)
    {
        this.offSet = offSet;
    }

    public void setAreaSize(int size)
    {
        this.areaSize = size;
    }

    // Use this for initialization
    void Start () {
        Distribute();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void Distribute()
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 position = GetDistributePosition();
            if (position != Vector3.zero)
            {
                GameObject o = Instantiate(targetObject, position, Quaternion.identity);
                o.transform.parent = this.transform;
            }
        }
    }

    Vector3 GetDistributePosition()
    {
        Vector3 position = new Vector3();
        float startTime = Time.realtimeSinceStartup;
        bool test = false;
        while (test == false)
        {
            Vector3 positionRaw = Random.insideUnitCircle * areaSize;
            position = new Vector3(positionRaw.x, offSet, positionRaw.y);
            position += transform.position;
            test = !Physics.CheckSphere(position, 0.75f);
            if (Time.realtimeSinceStartup - startTime > 0.5f)
            {
                Debug.Log("Time out placing Minion!");
                return Vector3.zero;
            }
        }
        return position;
    }


}
