using UnityEngine;
using System.Collections;

[System.Serializable]
public class DataClass
{
    public int myInt;
    public float myFloat;
}

public class DemoScript : MonoBehaviour
{

    public Light myLight;
    public DataClass[] myClass;
    private Rigidbody myRigidBody;

    void Awake()
    {
        int myNum = AddTwo(9, 2);
        Debug.Log(myNum);

        myRigidBody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            MyFunction();
        }

        myRigidBody.velocity = 10.0f;
    }

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;
    }


    int AddTwo(int v1,int v2)
    {
        int returnVal = v1 + v2;
        return returnVal;
    }

}