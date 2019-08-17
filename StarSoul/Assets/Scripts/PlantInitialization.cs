using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantInitialization : MonoBehaviour
{
    public float Radius;
    public int Layer;
    public GameObject LandCursor;
    // Use this for initialization

    private void Awake()
    {
        PlantCoreRadius(Radius, Layer);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlantCoreRadius(float Radius, int Layer)
    {
        float[] LayerAngle = new float[Layer];

        for (int i = 0; i < Layer; i++)
        {
            LayerAngle[i] = Mathf.Atan2(1, (Radius + i));
            for (float j = 0; j < (2 * Mathf.PI / LayerAngle[i]); j++)
            {
                if (i != 10 && i != 30)
                {
                    Instantiate(LandCursor, transform.position + new Vector3((Radius + i) * Mathf.Sin(LayerAngle[i] * j), (Radius + i) * Mathf.Cos(LayerAngle[i] * j), 0), Quaternion.Euler(0, 0, -j * LayerAngle[i] * Mathf.Rad2Deg));
                }

                //Debug.Log("I=" + i + ";J=" + j + ";LayerAngle=" + LayerAngle[i] + ";Position" + LandCursor.transform.position + ";LayerAngle[i] * j=" + LayerAngle[i] * j + ";Mathf.Sin(LayerAngle[i] * j)=" + Mathf.Sin(LayerAngle[i] * j) + ";Mathf.Cos(LayerAngle[i] * j)=" + Mathf.Cos(LayerAngle[i] * j));
            }
        }


    }
}
