using System.Collections.Generic;
using UnityEngine;

public class King : Chesspiece
{
    public override List<Vector2Int> GetAvaliableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        //right
        if(currnetX + 1 < tileCountX)
        {
            //right
            if (board[currnetX + 1, currnetY] == null)
            {
                r.Add(new Vector2Int(currnetX + 1, currnetY));
            }
            else
            {
                if(board[currnetX + 1, currnetY].team != team)
                {
                    r.Add(new Vector2Int(currnetX + 1, currnetY));
                }
            }
            //top right
            if(currnetY + 1 < tileCountY)
            {
                if (board[currnetX + 1, currnetY + 1] == null)
                {
                    r.Add(new Vector2Int(currnetX + 1, currnetY + 1));
                }
                else
                {
                    if (board[currnetX + 1, currnetY + 1].team != team)
                    {
                        r.Add(new Vector2Int(currnetX + 1, currnetY + 1));
                    }
                }
            }
            //bottom right
            if (currnetY - 1 >= 0)
            {
                if (board[currnetX + 1, currnetY - 1] == null)
                {
                    r.Add(new Vector2Int(currnetX + 1, currnetY - 1));
                }
                else
                {
                    if (board[currnetX + 1, currnetY - 1].team != team)
                    {
                        r.Add(new Vector2Int(currnetX + 1, currnetY - 1));
                    }
                }
            }
        }

        //left
        if (currnetX - 1 >= 0)
        {
            //left
            if (board[currnetX - 1, currnetY] == null)
            {
                r.Add(new Vector2Int(currnetX - 1, currnetY));
            }
            else
            {
                if (board[currnetX - 1, currnetY].team != team)
                {
                    r.Add(new Vector2Int(currnetX - 1, currnetY));
                }
            }
            //top left
            if (currnetY + 1 < tileCountY)
            {
                if (board[currnetX - 1, currnetY + 1] == null)
                {
                    r.Add(new Vector2Int(currnetX - 1, currnetY + 1));
                }
                else
                {
                    if (board[currnetX - 1, currnetY + 1].team != team)
                    {
                        r.Add(new Vector2Int(currnetX - 1, currnetY + 1));
                    }
                }
            }
            //bottom left
            if (currnetY - 1 >= 0)
            {
                if (board[currnetX - 1, currnetY - 1] == null)
                {
                    r.Add(new Vector2Int(currnetX - 1, currnetY - 1));
                }
                else
                {
                    if (board[currnetX - 1, currnetY - 1].team != team)
                    {
                        r.Add(new Vector2Int(currnetX - 1, currnetY - 1));
                    }
                }
            }
        }

        //up
        if(currnetY + 1 < tileCountY)
        {
            if(board[currnetX, currnetY + 1] == null || board[currnetX, currnetY + 1].team != team)
            {
                r.Add(new Vector2Int(currnetX, currnetY + 1));
            }
        }

        //down
        if (currnetY - 1 >= 0)
        {
            if (board[currnetX, currnetY - 1] == null || board[currnetX, currnetY - 1].team != team)
            {
                r.Add(new Vector2Int(currnetX, currnetY - 1));
            }
        }

        return r;
    }
}
