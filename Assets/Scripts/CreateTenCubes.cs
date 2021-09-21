using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CreateTenCubes : MonoBehaviour
{
    List<GameObject> cubes = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cubes.Count < 10)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(Random.Range(-9,9),Random.Range(-9,9),Random.Range(5, 10));
            cubes.Add(cube);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            var cubeForDestroy = cubes[Random.Range(0,cubes.Count)];
            cubes.Remove(cubeForDestroy);
            Destroy(cubeForDestroy);
        }
    }
}
