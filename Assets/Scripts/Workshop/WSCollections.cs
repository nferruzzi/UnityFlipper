using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct WSStruct {
    public int a;
    public float b;
    public Vector3 c;

    public WSStruct(int valA) {
        a = valA;
        b = 0f;
        c = Vector3.zero;
    }
}

public class WSCollections : MonoBehaviour
{

    public int[] arrayOfInts = { 1, 2, 3 };
    public WSStruct[] arrayOfStructs;
    public List<WSStruct> listOfStructs = new List<WSStruct>();
    public Dictionary<string, WSStruct> genericDict = new Dictionary<string, WSStruct>();

    void Start()
    {
        float[] array = new float[3];
        Debug.Log(array.Length);

        foreach (int v in arrayOfInts) {
            Debug.Log(v);
        }

        // Dizionario
        genericDict["ciao"] = new WSStruct(1);

        WSStruct temp;
        if (genericDict.TryGetValue("boh", out temp))
        {
            Debug.Log(temp);
        }

        ReturnStruct(out temp);
        ChangeStruct(ref temp);
    }

    void ReturnStruct(out WSStruct val) {
        val = new WSStruct();
        val.a = 1;
    }

    void ChangeStruct(ref WSStruct val) {
        val.a = 1;
    }

}
