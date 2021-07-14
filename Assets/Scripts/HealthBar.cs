using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Transform bar;
    public float size=1;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("BarSprite");
    }
    public void SetSize(float size)
    {
        bar.localScale = new Vector2(size, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SetSize(size++);
        }
    }
}
