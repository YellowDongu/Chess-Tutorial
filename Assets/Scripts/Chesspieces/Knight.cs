using System.Collections.Generic;
using UnityEngine;

public class Knight : Chesspiece
{
    public override List<Vector2Int> GetAvaliableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // Top right
        int x = currnetX + 1;
        int y = currnetY + 2;
        if(x < tileCountX && y < tileCountY)
        {
            if(board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }
        x = currnetX + 2;
        y = currnetY + 1;
        if (x < tileCountX && y < tileCountY)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }

        // Top Left
        x = currnetX - 1;
        y = currnetY + 2;
        if (x > 0 && y < tileCountY)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }
        x = currnetX - 2;
        y = currnetY + 1;
        if (x > 0 && y < tileCountY)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }

        // Bottom Right
        x = currnetX + 1;
        y = currnetY - 2;
        if (x < tileCountX && y >= 0)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }
        x = currnetX + 2;
        y = currnetY - 1;
        if (x < tileCountX && y >= 0)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }

        // Bottom Left
        x = currnetX - 1;
        y = currnetY - 2;
        if (x >= 0 && y >= 0)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }
        x = currnetX - 2;
        y = currnetY - 1;
        if (x >= 0 && y >= 0)
        {
            if (board[x, y] == null || board[x, y].team != team)
            {
                r.Add(new Vector2Int(x, y));
            }
        }

        return r;
    }
}
