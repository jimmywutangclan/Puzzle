using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTests : MonoBehaviour
{
    [SerializeField]
    private int rows = 10;
    [SerializeField]
    private int cols = 10;
    [SerializeField]
    private float step = 1.25f;
    [SerializeField]
    private GameObject square;

    private List<ITileColorComponent> colors;

    void Start()
    {
        colors = new List<ITileColorComponent>();

        float x = (cols / 2) * -step;
        float y = (rows / 2) * -step;
        
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                Vector2 pos = new Vector2(x, y);
                GameObject g = Instantiate(square, pos, Quaternion.identity);
                g.SetActive(true);
                ITileColorComponent color = g.GetComponent<ITileColorComponent>();
                colors.Add(color);
                x += step;
            }
            y += step;
            x = (cols / 2) * -step;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(ITileColorComponent color in colors) {
                color.InvertColor();
            }
        }
    }
}
