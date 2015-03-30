﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UGWProject
{
    class Map
    {
        private Dictionary<int, string> levels;
        private string[] lFiles;
        protected int mapX;
        protected int mapY;

        public Map()
        {
            levels = new Dictionary<int, string>();
        }

        public void LoadLevels()
        {
            StreamReader lRead;

            lFiles = Directory.GetFiles(@".", "*level*");

            // if (lFiles.Length == 0)
            // {
            //      Write "no levels found" somewhere
            // }

            foreach (string l in lFiles)
            {
                lRead = new StreamReader(l);

                string lvl = " "; //empty string
                string lvlIn = " "; //String being read
                string lCheck = " "; //Tells when reader should stop reading

                while ((lvlIn = lRead.ReadLine()) != null)
                {
                    //Check for characters
                    foreach (char c in lvlIn)
                    {
                        if (c == '@')
                        {
                            //create player object at location
                        }

                        if (c == '_')
                        {
                            //create block at location
                        }

                        if (c == '|')
                        {
                            //Create wall at location
                        }

                        if (c == 'x')
                        {
                            //Create switch at location
                        }

                        if (c == 'e')
                        {
                            //mapY += particular amount;
                            //mapX = (negative increment number);
                        }

                        //mapX += (particular number)

                    }
                }
            }
        }
    }
}
