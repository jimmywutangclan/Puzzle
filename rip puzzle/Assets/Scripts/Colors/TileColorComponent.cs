using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TileColorComponent : MonoBehaviour, ITileColorComponent
{
    private TileColor color;

    private SpriteRenderer ren;

    /// <summary>
    /// At initialization,  switch to a random color.
    /// </summary>
    void Start()
    {
        this.color = (TileColor)(Random.Range(0, 1 + (int)TileColor.LastColor));

        this.ren = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        this.ren.color = this.TileColorToColor();
    }

    private Color TileColorToColor()
    {
        switch (this.color)
        {
            case TileColor.Red:
                return new Color(1, 0, 0, 1);
            case TileColor.Blue:
                return new Color(0, 0, 1, 1);
            case TileColor.Green:
                return new Color(0, 1, 0, 1);
            case TileColor.Yellow:
                return new Color(1, 1, 0, 1);
            default:
                return new Color(0, 0, 0, 1);
        }
    }

    public TileColor GetColor()
    {
        return this.color;
    }

    public void InvertColor()
    {
        switch(this.color)
        {
            case TileColor.Red:
                this.color = TileColor.Green;
                break;
            case TileColor.Blue:
                this.color = TileColor.Yellow;
                break;
            case TileColor.Green:
                this.color = TileColor.Red;
                break;
            case TileColor.Yellow:
                this.color = TileColor.Blue;
                break;
        }
    }

}
