using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject image;
    static int num = 0;
    [SerializeField] TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Destroy(image);
        Destroy(gameObject);
        Destroy(bulletText);
    }
}
