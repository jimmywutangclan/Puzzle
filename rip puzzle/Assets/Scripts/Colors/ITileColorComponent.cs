using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileColor
{
    Red = 0,
    Blue,
    Green,
    Yellow,
    LastColor = Yellow
}

/// <summary>
/// Store the color of this tile and change its color accordingly
/// </summary>
public interface ITileColorComponent
{
    /// <summary>
    /// Get the color of this tile
    /// </summary>
    /// <returns>the color</returns>
    TileColor GetColor();

    /// <summary>
    /// Switch this tile's color to the opposite color
    /// </summary>
    void InvertColor();
}
