using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PongLibrary
{
    public static class ManagerCollision
    {
        public static bool CheckCollision(Player player, float X, float Y, List<Player> players, int width, int height)
        {

            var rec = new Rectangle((int)(X + player.X), (int)(Y + player.Y), 50, 50);

            foreach (var p in players)
            {
                if (p.UUID != player.UUID)
                {
                    if (rec.Intersects(new Rectangle((int)p.X, (int)p.Y, 50, 50)))
                    {
                        return true;
                    }
                }
            }

            var map = new Rectangle(0, 0, width, height);

            if (!map.Contains(rec))
            {

                Debug.WriteLine(map + " " + rec);
                return true;
            }


            return false;
        }
    }
}
