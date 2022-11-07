using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_TEST
{
    public class TableMap
    {
        public static int tbcellWidth = 70;
        public static int tbcellHeight = 70 ;
        
       
        private int row;
        private int column;

        public int Row 
        { 
            get { return row; } 
            set { row = value; } 
        }
        public int Column
        { 
            get { return column; }
            set { column = value; } 
        }
        private bool ktTRrung(int [,] ArrayMap, int i, int j)
        {
            for (int h = 1; h <= i; h++)
            {
                for (int k = 1; k <= j; k++)
                {
                    if (ArrayMap[i, j] == ArrayMap[h, k])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int [,] RandomCellMap()
        {
            Random random = new Random();
            int[,] ArrayMap = new int[row + 2, column + 2];
            for(int i=1;i<= row + 1;i++)
            {
                for(int j=1;j<= column + 1;j++)
                {
                    ArrayMap[i,j] = random.Next(1,99);
                    for (int count = 1; count <= (row * column); count++)
                    {
                        if (!ktTRrung(ArrayMap, i, j))
                        {
                            ArrayMap[i, j] = random.Next(1, 99);

                        }
                    }
                }
            }
            return ArrayMap;
        }
        public int [,] InputFile(string strfile)
        {          
            List<string> list = File.ReadAllLines(strfile).ToList();
            int count = 0;
            string []strtemp;
            strtemp = list[0].Split(' ');
            this.row = Convert.ToInt32(strtemp[0]);
            this.column = Convert.ToInt32(strtemp[1]);
            int[,] ArrayMap = new int[row + 2, row + 2];
            foreach (var item in list)
            {
                if (count > 0)
                {
                    strtemp = item.Split("\t");
                    for (int i = 0; i < this.column; i++)
                    {
                        ArrayMap[count, i+1] = Convert.ToInt32(strtemp[i]);
                    }                 
                }
                count++;    
            }
            return ArrayMap;
        }
    }
}
