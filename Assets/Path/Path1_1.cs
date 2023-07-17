using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path1_1 : MonoBehaviour
{
    [SerializeField] Transform[] Points;
    [SerializeField] private float movespeed = 1f;
    private int PointIndex=0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[PointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Points.Length);
        if(PointIndex <= Points.Length - 1){
            transform.position = Vector2.MoveTowards(transform.position, Points[PointIndex].transform.position, movespeed * Time.deltaTime);
            Debug.Log(transform.position);
            if(transform.position == Points[PointIndex].transform.position){
                Debug.Log("In");
                PointIndex++;
            }
        }
    }
}
