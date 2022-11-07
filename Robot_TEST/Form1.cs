namespace Robot_TEST
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public Form1()
        {
            InitializeComponent();
            _instance = this;
        }
        //Object thislock = new object();
        private int[,] Arraymap;
        private bool[,] check;
        private static int ROW;
        private static int COLUMN ;
        private static int Max = -99999999;
        private string strPath;
        List<int> Path;
        static void DoFoo(int NumSlepp)
        {
            System.Threading.Thread.Sleep(NumSlepp);
        }
        private void start_Click(object sender, EventArgs e)
        {
            _instance.Init(1, 1);
            UpdateColer(1, 1, Color.White);

        }
        public static void UpdateColer(int index_i, int index_j, System.Drawing.Color color)

        {
            foreach (Control item in _instance.flpMap.Controls)
            {
                if (item.Name == "button_" + index_i + '_' + index_j + '_' + _instance.Arraymap[index_i, index_j].ToString())
                {
                    item.BackColor = color;
                }
            }            
        }
        public static void UpdateColer1(int index_i, int index_j)

        {
            foreach (Control item in _instance.flpMap.Controls)
            {
                if (item.Name == "button_" + index_i + '_' + index_j + '_' + _instance.Arraymap[index_i, index_j].ToString())
                {
                    item.BackColor = Color.Aqua;
                }
            }
        }//= Image.FromFile(@"D:\Documents\New folder\bkg0728.PNG")
        public static void UpdateImage(int index_i, int index_j, Image bitmap )

        {
            foreach (Control item in _instance.flpMap.Controls)
            {
                if (item.Name == "button_" + index_i + '_' + index_j + '_' + _instance.Arraymap[index_i, index_j].ToString())
                {
                    item.BackgroundImage = bitmap;
                }
            }
        }
        private void CreatMap_Click(object sender, EventArgs e)
        {
            CreatMap.Enabled = false;
            
            TableMap map = new TableMap();
            if (DataFromFlie.Checked)
            {
                Arraymap = new int[map.Row + 1, map.Column + 1];
                Arraymap = map.InputFile("ArrayList.txt");
                ROW = map.Row;
                COLUMN = map.Column;
            }
            else 
            {
                map.Row = Convert.ToInt32(numROW.Value);
                map.Column = Convert.ToInt32(numCOLUMN.Value);
                Arraymap = new int[map.Row + 2, map.Column + 2];
                Arraymap = map.RandomCellMap();
                ROW = map.Row;
                COLUMN = map.Column;
            }         
            for (int i = 1; i <= map.Row; i++)
            {
                for (int j = 1; j <= map.Column; j++)
                {
                    Button btn = new Button { Width = TableMap.tbcellWidth, Height = TableMap.tbcellHeight };
                    string namebutton = "button_" + i.ToString() + "_" + j.ToString() + "_"+ Arraymap[i, j].ToString();
                    btn.Name = namebutton;
                    //btn.Text = Arraymap[i, j].ToString();
                    btn.Margin = new Padding(0, 0, 0, 0);
                    btn.BackColor = Color.Aqua;
                    btn.Font = new Font("Times New Roman", 15, FontStyle.Bold );
                    btn.ForeColor = Color.Black;
                    _instance.flpMap.Controls.Add(btn);
                    btn.Click += Btn_Click;
                    DoFoo(30);
                    Application.DoEvents();
                }                  
            }
            flpMap.Width = (TableMap.tbcellWidth * map.Column) + 20;
            flpMap.Height = (TableMap.tbcellHeight * map.Row) + 20;
            flpMap.Location = new Point(12,12);
            panel1.Location = new Point(620 + (TableMap.tbcellHeight * (map.Column - 8)), 12);
            panel2.Location = new Point(620 + (TableMap.tbcellHeight * (map.Column - 8)), 218);
            _instance.Size = new Size((TableMap.tbcellWidth + 15) * map.Column+400, (TableMap.tbcellHeight + 12) * map.Row);
            check = new bool[map.Row + 5, map.Column + 5];
            for (int i = 0; i <= map.Row + 4; i++)
            {
                for (int j = 0; j <= map.Column + 4; j++)
                {
                    _instance.check[i, j] = false;
                }
            }
            for (int i = 1; i <= map.Row; i++)
            {
                for (int j = 1; j <= map.Column; j++)
                {
                    UpdateText(i, j);
                }
            }
            start.Enabled = true;
            reset.Enabled = true;
            stop.Enabled = true;
        }
        /// ???ng ?i b?t ??u ô[x,y] ô mà ???c click
        private void Btn_Click(object? sender, EventArgs e)
        {
            string namenutton = (sender as Button).Name;
            string []arrname = namenutton.Split('_');
            _instance.Init(Convert.ToInt32(arrname[1]), Convert.ToInt32(arrname[2]));
            UpdateColer(Convert.ToInt32(arrname[1]), Convert.ToInt32(arrname[2]), Color.White);
        }

        public static void UpdateText(int index_i,int index_j)

        {
            foreach (Control item in _instance.flpMap.Controls)
            {
                if (item.Name == "button_" + index_i + '_' + index_j+'_'+ _instance.Arraymap[index_i, index_j].ToString())
                {
                    item.Text = _instance.Arraymap[index_i, index_j].ToString();
                }
            }
        }

        public int TRy(int x, int y)
        {
            Robot robot = new Robot();
            robot.Score = int.Parse(Lbscore.Text);
            robot.Score += int.Parse(Arraymap[x, y].ToString());
            robot.Step = Convert.ToInt32(LBstep.Text);
            if(robot.Step==0)
                strPath = Arraymap[x, y].ToString();
            else
                strPath = "->" + Arraymap[x, y];        
            DoFoo(700);
            if(Arraymap[x, y]!=0)
            {
                robot.Step += 1;
                Path.Add(Arraymap[x, y]);
            }
            Application.DoEvents();
            Pathofrobot.Text += strPath;
            Lbscore.Text = robot.Score.ToString();
            LBstep.Text = robot.Step.ToString();
            UpdateColer(x, y , Color.DarkGray);
            _instance.check[x, y] = true;
            try
            {
                if (_instance.check[x + 1, y] == true && _instance.check[x, y + 1] == true && _instance.check[x - 1, y] == true && _instance.check[x, y - 1] == true)
                {
                    UpdateColer(x, y, Color.DarkRed);
                    return _instance.Arraymap[x, y];
                }
            }
                    
            catch (Exception)
            {
            }           
            int MAX = -99999999;
            int i = 0, j = 0;
            if (_instance.check[x + 1, y] != true && _instance.Arraymap[x + 1, y] > MAX)
            {
                MAX = _instance.Arraymap[x + 1, y];
                i = x + 1;
                j = y;
                
            }
            if (_instance.check[x, y + 1] != true && _instance.Arraymap[x, y + 1] > MAX)
            {
                MAX = _instance.Arraymap[x, y + 1];
                i = x;
                j = y + 1;
            }
            if (_instance.check[x - 1, y] != true && _instance.Arraymap[x - 1, y] > MAX)
            {
                MAX = _instance.Arraymap[x - 1, y];
                i = x - 1;
                j = y;
            }

            if (_instance.check[x, y - 1] != true && _instance.Arraymap[x, y - 1] > MAX)
            {
                MAX = _instance.Arraymap[x, y - 1];
                i = x;
                j = y - 1;
            }
            return _instance.Arraymap[x, y] + TRy(i, j);
        }
        public void Init(int x, int y)
        {
            Lbscore.Text = "0";
            LBstep.Text = "0";
            Pathofrobot.Text = "";
            for (int i = 1; i <= ROW; i++)
                for (int j = 1; j <= COLUMN; j++)
                {
                    UpdateColer1(i, j);
                }
            TableMap map = new TableMap();
            map.Row = ROW;
            map.Column = COLUMN;
            Path = new List<int>();
            for (int i = 1; i <= map.Row; i++)
            {
                for (int j = 1; j <= map.Column; j++)
                    _instance.check[i, j] = false;
            }              
            for (int i = 0; i <= map.Row; i++)
            {
                _instance.check[0, i] = true;
                _instance.check[i, 0] = true;
                _instance.check[map.Row + 1, i] = true;
                _instance.check[i, map.Row + 1] = true;
            }
            Path.Clear();
            int temp = TRy(x, y);
            if (temp > Max)
            {
                Max = temp;
            }
        }
        public static void PathRobot()
        {
            int temp_x = 1;
            int temp_y = 1;
            foreach (var item in _instance.Path)
            {
                if (_instance.Arraymap[temp_x + 1, temp_y] == item)
                {
                    temp_x += 1;
                    
                }
                if (_instance.Arraymap[temp_x, temp_y + 1] == item)
                {
                    temp_y += 1;
                    
                }
                if (_instance.Arraymap[temp_x - 1, temp_y] == item)
                {
                    temp_x -= 1;
                   
                }
                if (_instance.Arraymap[temp_x, temp_y - 1] == item)
                {
                    temp_y -= 1;
                    
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void ClearElement(int index_i, int index_j)

        {
            foreach (Control item in _instance.flpMap.Controls)
            {
                if (item.Name == "button_" + index_i + '_' + index_j + '_' + _instance.Arraymap[index_i, index_j].ToString())
                {
                    _instance.flpMap.Invoke((Action)(() =>
                    {
                        _instance.flpMap.Controls.Remove(item);
                    }));
                }
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            CreatMap.Enabled = true;
            start.Enabled = false;
            stop.Enabled = false;
            Lbscore.Text = "0";
            LBstep.Text = "0";
            Pathofrobot.Text = "";
            for (int i = 1; i <= ROW; i++)
            {
                for (int j = 1; j <= COLUMN; j++)
                {
                    ClearElement(i, j);
                    DoFoo(30);
                    Application.DoEvents();
                }
            }                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Enabled = false;
            reset.Enabled = false;
            stop.Enabled = false;
        }
    }
}