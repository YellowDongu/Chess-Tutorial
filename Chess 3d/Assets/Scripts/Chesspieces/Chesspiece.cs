using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChessPieceType
{
    None = 0,
    Pawn = 1,
    Rook = 2,
    Knight = 3,
    Bishop = 4,
    Queen = 5,
    King = 6
}

public class Chesspiece : MonoBehaviour
{
    // Start is called before the first frame update
    public int team;
    public int currnetX;
    public int currnetY;
    public ChessPieceType type;

    private Vector3 desiredPosistion;
    private Vector3 desiredScale;
}
