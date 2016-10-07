using UnityEngine;
using System.Collections;

public class ShellSpawner : MonoBehaviour {
    public GameObject myObject;
    public Vector3 spawnvec;
    public float Timer;
    public float spawnnumber;

    void Awake()
    {
         Timer = Time.time + 2;
    }

    void Update()
    {


        spawnvec = new Vector3(Random.Range(-40f, 40f), 40, Random.Range(-40f, 40f));
        if (Timer < Time.time)
        {
            Instantiate(myObject, spawnvec, Quaternion.Euler(90f, 0f, 0f));
            Timer = Time.time + 3;
        } 
    }
}