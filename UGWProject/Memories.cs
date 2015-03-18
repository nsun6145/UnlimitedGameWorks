using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace UGWProject
{
    class Memories : GamePiece
    {
        //attributes
        private int totMem;

        //properties
        public int TotMem
        {
            get { return totMem; }
            set { totMem = value; }
        }

        //constructor
        public Memories(int numofmemories, Rectangle memorect, Texture2D memotexture):base(memorect,memotexture)
        {
            totMem = numofmemories; 
        }

        //add memory method when player collides with memeory
        public void AddMemory(Player playr)
        {
            //stub. Add one to playr memories
        }
    }
}
