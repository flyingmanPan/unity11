using UnityEngine;
using System.Collections;

public class CamCtrl: MonoBehaviour
{
    public Transform target;
    public float distanceH = 20f;
    public float distanceV = 7f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 nextpos = target.forward * -1 * distanceH + target.up * distanceV + target.position;
        this.transform.position = nextpos;
        this.transform.LookAt(target);
    }
}