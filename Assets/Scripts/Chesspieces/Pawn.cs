using System.Collections.Generic;
using UnityEngine;

public class Pawn : Chesspiece
{
    public override List<Vector2Int> GetAvaliableMoves(ref Chesspiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        int direction = (team == 0) ? 1 : -1;
        
        //One in front
        if(board[currnetX, currnetY + direction] == null)
        {
            r.Add(new Vector2Int(currnetX, currnetY + direction));
        }

        //Two in front
        if (board[currnetX, currnetY + direction] == null)
        {
            if (team == 0 && currnetY == 1 && board[currnetX, currnetY + (direction * 2)] == null)
            {
                r.Add(new Vector2Int(currnetX, currnetY + (direction * 2)));
            }
            if (team == 1 && currnetY == 6 && board[currnetX, currnetY + (direction * 2)] == null)
            {
                r.Add(new Vector2Int(currnetX, currnetY + (direction * 2)));
            }
        }

        // Kill move
        if (currnetX != tileCountX - 1)
        {
            if (board[currnetX + 1, currnetY + direction] != null && board[currnetX + 1, currnetY + direction].team != team)
            {
                r.Add(new Vector2Int(currnetX + 1, currnetY + direction));
            }
        }
        if (currnetX != 0)
        {
            if(board[currnetX - 1, currnetY + direction] != null && board[currnetX - 1, currnetY + direction].team != team)
            {
                r.Add(new Vector2Int(currnetX - 1, currnetY + direction));
            }
        }

        return r;
    }
}
