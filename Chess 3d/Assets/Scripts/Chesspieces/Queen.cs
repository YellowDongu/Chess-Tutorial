using System.Collections.Generic;
using UnityEngine;

public class Queen : Chesspiece
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
                if (board[currnetX, i].team != team)
                {
                    r.Add(new Vector2Int(currnetX, i));
                }
                break;
            }
        }

        //Up
        for (int i = currnetY + 1; i < tileCountY; i++)
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

        //top Right
        for (int x = currnetX + 1, y = currnetY + 1; x < tileCountX && y < tileCountY; x++, y++)
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
        for (int x = currnetX + 1, y = currnetY - 1; x < tileCountX && y >= 0; x++, y--)
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