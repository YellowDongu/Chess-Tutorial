using System.Collections.Generic;
using UnityEngine;

public class Rook : Chesspiece
{
    public override List<Vector2Int> GetAvaliableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        //Down
        for (int i = currnetY - 1; i >= 0; i--)
        {
            if (board[currnetX, i] == null)
            {
                r.Add(new Vector2Int(currnetX, i));
            }
            if (board[currnetX, i] != null)
            {
                if(board[currnetX, i].team != team)
                {
                    r.Add(new Vector2Int(currnetX, i));
                }
                break;
            }
        }

        //Up
        for (int i = currnetY  + 1; i < tileCountY; i++)
        {
            if (board[currnetX, i] == null)
            {
                r.Add(new Vector2Int(currnetX, i));
            }
            if (board[currnetX, i] != null)
            {
                if (board[currnetX, i].team != team)
                {
                    r.Add(new Vector2Int(currnetX, i));
                }
                break;
            }
        }

        //Left
        for (int i = currnetX - 1; i >= 0; i--)
        {
            if (board[i, currnetY] == null)
            {
                r.Add(new Vector2Int(i, currnetY));
            }
            if (board[i, currnetY] != null)
            {
                if (board[i, currnetY].team != team)
                {
                    r.Add(new Vector2Int(i, currnetY));
                }
                break;
            }
        }

        //Right
        for (int i = currnetX + 1; i < tileCountX; i++)
        {
            if (board[i, currnetY] == null)
            {
                r.Add(new Vector2Int(i, currnetY));
            }
            if (board[i, currnetY] != null)
            {
                if (board[i, currnetY].team != team)
                {
                    r.Add(new Vector2Int(i, currnetY));
                }
                break;
            }
        }

        return r;
    }
}
