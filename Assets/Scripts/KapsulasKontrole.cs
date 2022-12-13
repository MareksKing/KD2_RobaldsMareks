using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    private int i;
    [SerializeField] private UnityEngine.Material material;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(i == 60){

            //https://answers.unity.com/questions/314737/how-to-randomly-change-a-color-on-an-object-in-c.html//
            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            Material[] materials = GetComponent<MeshRenderer>().materials;
            materials[0].SetColor("_Color", newColor);
            i=0;
        }
        i++;
    }
}
