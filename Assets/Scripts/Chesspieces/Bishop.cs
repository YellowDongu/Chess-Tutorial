using System.Collections.Generic;
using UnityEngine;

public class Bishop : Chesspiece
{
    public override List<Vector2Int> GetAvaliableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        //top Right
        for (int x = currnetX + 1, y = currnetY + 1; x < tileCountX && y < tileCountY; x++, y++)
        {
            if(board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if(board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        //Top Left
        for (int x = currnetX - 1, y = currnetY + 1; x >= 0 && y < tileCountY; x--, y++)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        //Bottom Right
        for (int x = currnetX + 1, y = currnetY - 1; x < tileCountX && y  >= 0; x++, y--)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        //Bottom Left
        for (int x = currnetX - 1, y = currnetY - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }
        return r;
    }
}