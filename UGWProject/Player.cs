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
    class Player:Character
    {
        //attributes
        private int memsColl;//Memories collected by the player
        private int moveSpd;//player speed default;
        private int spdWithBlock;//the speed of the player while moving the block
        KeyboardState kboardstate;//getting the keyboard state;
        KeyboardState prevKeyPressed; //takes the previous key that was pressed
        //string[] aliveControl = {"A","D","F"}; //the list of keys that can be pressed while alive
        //string[] deadControl = {"W","A","S","D"};//list of keys that can be pressed while dead. 
        //Going to also need a key[] for the space bar
       // Boolean[] activeKeyD = {false,false,false,false};//if a key is active in the dead state
       // Boolean[] activeKeyA = {false,false,false};//if a key is active in the alive state

        //properties
        public int MemsColl
        {
            get { return memsColl; }
            set { memsColl = value; }
        }

        public int MoveSpeed
        {
            get { return moveSpd; }
            set { moveSpd = value; }
        }

        public int SpeedWithBlock
        {
            get { return spdWithBlock; }
            set { spdWithBlock = value; }
        }

        //constructor
        public Player(Rectangle playrect, Texture2D playtext):base(false, playrect,playtext)
        {
            
        }

        //overrides move method to be specific to character
        override public void Move()
        {
            //takes the first key pressed in a returned array of keys
            kboardstate = new KeyboardState();
            //Keys[] keyarray = kboardstate.GetPressedKeys();
            //going to add aplayer enum later in
            if (IsDead == false)
            {
                if (kboardstate.IsKeyDown(Keys.A))
                {
                    //activeKeyA[0] = true;
                    ObjRect = new Rectangle(ObjRect.X - moveSpd, ObjRect.Y, ObjRect.Width, ObjRect.Height);
                }
                else if(kboardstate.IsKeyDown(Keys.D))
                {
                    ObjRect = new Rectangle(ObjRect.X + moveSpd, ObjRect.Y, ObjRect.Width, ObjRect.Height);
                }
                else if (kboardstate.IsKeyDown(Keys.F) && prevKeyPressed.IsKeyUp(Keys.A))
                {
                    //pushing/pulling from the left side of the block
                }
                else if(kboardstate.IsKeyDown(Keys.F) && prevKeyPressed.IsKeyUp(Keys.D))
                {
                    //pushing/pulling the block from the right side.
                }
                else if (kboardstate.IsKeyDown(Keys.Space))
                {
                    //jumping
                }
                else if (kboardstate.IsKeyDown(Keys.D) && prevKeyPressed.IsKeyUp(Keys.Space))
                {
                    //arc going to the right jump
                }
                else if (kboardstate.IsKeyDown(Keys.A) && prevKeyPressed.IsKeyUp(Keys.Space))
                {
                    //jumping to the left
                }
                else if (kboardstate.IsKeyDown(Keys.Escape))
                {
                    //pause menu
                }
                prevKeyPressed = kboardstate;
            }
            
        }
  



    }
}
