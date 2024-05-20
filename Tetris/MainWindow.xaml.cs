using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image Z1;
        Image Z2;
        Image Z3;
        Image Z4;
        int Block1X;
        int Block1Y;
        int Block2X;
        int Block2Y;
        int Block3X;
        int Block3Y;
        int Block4X;
        int Block4Y;
        int Rlock2;
        int Rlock4;
        string block;
        string NästaB;
        bool[,] kolG = new bool[20, 10];
        bool startat = false;

        public MainWindow()
        {
            InitializeComponent();
            //Start();
            Next();
            skapa();
        }

        //private void Start()
        //{
        //    Random r = new Random();
        //    switch (r.Next(7))
        //    {
        //        case 0:
        //            BlockZ();
        //            block = "BlockZ";
        //            break;
        //            case 1:
        //            BlockS();
        //            block = "BlockS";
        //            break;
        //            case 2:
        //            BlockL();
        //            block = "BlockL";
        //            break;
        //            case 3:
        //            BlockJ();
        //            block = "BlockJ";
        //            break;
        //            case 4:
        //            BlockO();
        //            block = "BlockO";
        //            break;
        //            case 5:
        //            BlockI();
        //            block = "BlockI";
        //            break;
        //            case 6:
        //            BlockT();
        //            block = "BlockT";
        //            break;
        //    }
        //}

        private void Lås()
        {
            
        }

        private void Next() 
        {
            Random r = new Random();
            switch (r.Next(7))
            {
                case 0:
                    
                    NästaB = "BlockZ";
                    
                    break;
                case 1:
                    
                    NästaB = "BlockS";
                    break;
                case 2:
                    
                    NästaB = "BlockL";
                    break;
                case 3:
                    
                    NästaB = "BlockJ";
                    break;
                case 4:
                    
                    NästaB = "BlockO";
                    break;
                case 5:
                    
                    NästaB = "BlockI";
                    break;
                case 6:
                    
                    NästaB = "BlockT";
                    break;
            }
            BitmapImage RBlock = new BitmapImage(new Uri($"pack://application:,,,/Tetris;component/Former/{NästaB[5]}.png"));
            Nblock.Source = RBlock;
        }
        
        private void skapa()
        {
            switch (NästaB)
            {
                case "BlockZ":
                    BlockZ();
                    break;

                case "BlockS":
                    BlockS();
                    break;

                case "BlockL":
                    BlockL();
                    break;

                case "BlockJ":
                    BlockJ();
                    break;

                case "BlockO":
                    BlockO();
                    break;

                case "BlockI":
                    BlockI();
                    break;

                case "BlockT":
                    BlockT();
                    break;
            }
            kolG[Block1Y, Block1X] = true;
            kolG[Block2Y, Block2X] = true;
            kolG[Block3Y, Block3X] = true;
            kolG[Block4Y, Block4X] = true;
            block = NästaB;
            Next();
        }

        #region
        private void BlockZ()
        {
            #region ZBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/Z-BLock.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Random r = new Random();
            if (r.Next(2) == 0)
            {
                Rlock2 = 1;
                Block1X = 3;
                Block1Y = 0;
                Block2X = 4;
                Block2Y = 0;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 5;
                Block4Y = 1;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock2 = 2;
                Block1X = 5;
                Block1Y = 0;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 4;
                Block4Y = 2;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
                #endregion
            }
        }
        private void BlockS()
        {

            #region SBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/S-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Random r = new Random();
            if (r.Next(2) == 0)
            {
                Rlock2 = 1;
                Block1X = 5;
                Block1Y = 0;
                Block2X = 4;
                Block2Y = 0;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 3;
                Block4Y = 1;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock2 = 2;
                Block1X = 4;
                Block1Y = 0;
                Block2X = 4;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 1;
                Block4X = 5;
                Block4Y = 2;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            #endregion

        }
        private void BlockL()
        {

            #region LBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/L-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Random r = new Random();
            int i = r.Next(4);
            if (i == 0)
            {
                Rlock4 = 1;
                Block1X = 4;
                Block1Y = 1;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 6;
                Block3Y = 1;
                Block4X = 6;
                Block4Y = 0;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 1)
            {
                Rlock4 = 2;
                Block1X = 5;
                Block1Y = 2;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 0;
                Block4X = 4;
                Block4Y = 0;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 2)
            {
                Rlock4 = 3;
                Block1X = 6;
                Block1Y = 1;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 4;
                Block4Y = 2;

                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock4 = 4;
                Block1X = 5;
                Block1Y = 0;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 2;
                Block4X = 6;
                Block4Y = 2;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            #endregion
        }
        private void BlockJ()
        {

            #region JBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/J-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Random r = new Random();
            int i = r.Next(4);
            if (i == 0)
            {
                Rlock4 = 1;
                Block1X = 4;
                Block1Y = 1;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 6;
                Block3Y = 1;
                Block4X = 6;
                Block4Y = 2;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 1)
            {
                Rlock4 = 2;
                Block1X = 5;
                Block1Y = 0;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 2;
                Block4X = 4;
                Block4Y = 2;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 2)
            {
                Rlock4 = 3;
                Block1X = 6;
                Block1Y = 1;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 4;
                Block4Y = 0;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock4 = 4;
                Block1X = 5;
                Block1Y = 2;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 0;
                Block4X = 6;
                Block4Y = 0;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            #endregion
        }
        private void BlockI()
        {
            #region IBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/I-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Random r = new Random();
            if (r.Next(2) == 0)
            {
                Rlock2 = 1;
                Block1X = 3;
                Block1Y = 0;
                Block2X = 4;
                Block2Y = 0;
                Block3X = 5;
                Block3Y = 0;
                Block4X = 6;
                Block4Y = 0;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock2 = 2;
                Block1X = 4;
                Block1Y = 0;
                Block2X = 4;
                Block2Y = 1;
                Block3X = 4;
                Block3Y = 2;
                Block4X = 4;
                Block4Y = 3;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            #endregion

        }
        private void BlockT()
        {

            #region TBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/T-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;

            Random r = new Random();
            int i = r.Next(4);
            if (i == 0)
            {
                Rlock4 = 1;
                Block1X = 4;
                Block1Y = 0;
                Block2X = 5;
                Block2Y = 0;
                Block3X = 6;
                Block3Y = 0;
                Block4X = 5;
                Block4Y = 1;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 1)
            {
                Rlock4 = 2;
                Block1X = 5;
                Block1Y = 0;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 2;
                Block4X = 4;
                Block4Y = 1;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else if (i == 2)
            {
                Rlock4 = 3;
                Block1X = 6;
                Block1Y = 1;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 4;
                Block3Y = 1;
                Block4X = 5;
                Block4Y = 0;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }
            else
            {
                Rlock4 = 4;
                Block1X = 5;
                Block1Y = 2;
                Block2X = 5;
                Block2Y = 1;
                Block3X = 5;
                Block3Y = 0;
                Block4X = 6;
                Block4Y = 1;
                #region Z1
                Grid.SetColumn(Z1, Block1X);
                Grid.SetRow(Z1, Block1Y);
                tetrisgrid.Children.Add(Z1);
                #endregion
                #region Z2
                Grid.SetColumn(Z2, Block2X);
                Grid.SetRow(Z2, Block2Y);
                tetrisgrid.Children.Add(Z2);
                #endregion
                #region Z3
                Grid.SetColumn(Z3, Block3X);
                Grid.SetRow(Z3, Block3Y);
                tetrisgrid.Children.Add(Z3);
                #endregion
                #region Z4
                Grid.SetColumn(Z4, Block4X);
                Grid.SetRow(Z4, Block4Y);
                tetrisgrid.Children.Add(Z4);
                #endregion
            }

            #endregion
        }
        private void BlockO()
        {

            #region OBlock
            BitmapImage RBlock = new BitmapImage(new Uri("pack://application:,,,/Tetris;component/O-Block.png"));
            Z1 = new Image();
            Z1.Source = RBlock;
            Z2 = new Image();
            Z2.Source = RBlock;
            Z3 = new Image();
            Z3.Source = RBlock;
            Z4 = new Image();
            Z4.Source = RBlock;
            Block1X = 4;
            Block1Y = 0;
            Block2X = 5;
            Block2Y = 0;
            Block3X = 4;
            Block3Y = 1;
            Block4X = 5;
            Block4Y = 1;
            #region Z1
            Grid.SetColumn(Z1, Block1X);
            Grid.SetRow(Z1, Block1Y);
            tetrisgrid.Children.Add(Z1);
            #endregion
            #region Z2
            Grid.SetColumn(Z2, Block2X);
            Grid.SetRow(Z2, Block2Y);
            tetrisgrid.Children.Add(Z2);
            #endregion
            #region Z3
            Grid.SetColumn(Z3, Block3X);
            Grid.SetRow(Z3, Block3Y);
            tetrisgrid.Children.Add(Z3);
            #endregion
            #region Z4
            Grid.SetColumn(Z4, Block4X);
            Grid.SetRow(Z4, Block4Y);
            tetrisgrid.Children.Add(Z4);
            #endregion
            #endregion
        }
        #endregion
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left || e.Key == Key.A) 
            {
                if (Block1X == 0 || Block2X == 0 || Block3X == 0 || Block4X == 0) return;
                    Block1X--;
                    Block2X--;
                    Block3X--;
                    Block4X--;
                    Grid.SetColumn(Z1, Block1X);
                    Grid.SetColumn(Z2, Block2X);
                    Grid.SetColumn(Z3, Block3X);
                    Grid.SetColumn(Z4, Block4X);
                
            }
            if (e.Key == Key.Right || e.Key == Key.D)
            {
                if (Block1X == 9 || Block2X == 9 || Block3X == 9 || Block4X == 9) return;

                Block1X++;
                Block2X++;
                Block3X++;
                Block4X++;
                Grid.SetColumn(Z1, Block1X);
                Grid.SetColumn(Z2, Block2X);
                Grid.SetColumn(Z3, Block3X);
                Grid.SetColumn(Z4, Block4X);

            }
            if (e.Key == Key.Down || e.Key == Key.S)
            {
                if (Block1Y == 19 || Block2Y == 19 || Block3Y == 19 || Block4Y == 19)
                {
                        skapa();
                        return; 
                }
                
                    Block1Y++;
                    Block2Y++;
                    Block3Y++;
                    Block4Y++;
                if (!seLås())
                {
                    kolG[Block1Y - 1, Block1X] = false;
                    kolG[Block2Y - 1, Block2X] = false;
                    kolG[Block3Y - 1, Block3X] = false;
                    kolG[Block4Y - 1, Block4X] = false;
                    kolG[Block1Y, Block1X] = true;
                    kolG[Block2Y, Block2X] = true;
                    kolG[Block3Y, Block3X] = true;
                    kolG[Block4Y, Block4X] = true;

                    Grid.SetRow(Z1, Block1Y);
                    Grid.SetRow(Z2, Block2Y);
                    Grid.SetRow(Z3, Block3Y);
                    Grid.SetRow(Z4, Block4Y);
                }
                else
                {

                    skapa();
                }
            }
            if (e.Key == Key.Up || e.Key == Key.W)
            {
                if (Block1Y == 19 || Block2Y == 19 || Block3Y == 19 || Block4Y == 19)
                {
                    skapa();
                    return;
                }
                for (int i = 0; i < 19; i++)
                {
                    Block1Y++;
                    Block2Y++;
                    Block3Y++;
                    Block4Y++;
                    if (!seLås())
                    {
                        kolG[Block1Y - 1, Block1X] = false;
                        kolG[Block2Y - 1, Block2X] = false;
                        kolG[Block3Y - 1, Block3X] = false;
                        kolG[Block4Y - 1, Block4X] = false;
                        kolG[Block1Y, Block1X] = true;
                        kolG[Block2Y, Block2X] = true;
                        kolG[Block3Y, Block3X] = true;
                        kolG[Block4Y, Block4X] = true;
                    }
                    else break;
                    if (Block1Y == 19 || Block2Y == 19 || Block3Y == 19 || Block4Y == 19)
                    {
                        kolG[Block1Y, Block1X] = true;
                        kolG[Block2Y, Block2X] = true;
                        kolG[Block3Y, Block3X] = true;
                        kolG[Block4Y, Block4X] = true;

                        break;
                    }
                }
                Grid.SetRow(Z1, Block1Y);
                Grid.SetRow(Z2, Block2Y);
                Grid.SetRow(Z3, Block3Y);
                Grid.SetRow(Z4, Block4Y);
                skapa();
            }
            if (e.Key == Key.Z || e.Key == Key.O)
            {
                switch (block)
                {
                    case "BlockZ":
                        if (Rlock2 == 1)
                        {
                            Rlock2 = 2;
                            Block1X += 2;
                            Block2X += 1;
                            Block3X += 0;
                            Block4X -= 1;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 0;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            if (Block1X == 1) return;
                            Rlock2 = 1;
                            Block1X -= 2;
                            Block2X -= 1;
                            Block3X -= 0;
                            Block4X += 1;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y += 0;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockS":
                        if (Rlock2 == 1)
                        {
                            //till stående
                            Rlock2 = 2;
                            Block1X -= 1;
                            Block2X += 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 0;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande
                            if (Block3X == 1) return;
                            Rlock2 = 1;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y += 0;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockL":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 0) return;
                            //till stående höger
                            Rlock4 = 2;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 1;
                            Block2Y += 0;
                            Block3Y -= 1;
                            Block4Y -= 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block2X == 9) return;
                            Rlock4 = 3;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X += 0;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y += 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 4;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y += 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande botten
                            if (Block1X == 0) return;
                            Rlock4 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X -= 0;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y -= 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockJ":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 0) return;
                            //till stående höger
                            Rlock4 = 2;
                            Block1X -= 1;
                            Block2X += 0;
                            Block3X += 1;
                            Block4X -= 0;
                            Block1Y -= 1;
                            Block2Y += 0;
                            Block3Y += 1;
                            Block4Y += 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block1X == 9) return;
                            Rlock4 = 3;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y += 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 4;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X += 0;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y -= 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande botten
                            if (Block1X == 0) return;
                            Rlock4 = 1;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y -= 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockT":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 0) return;
                            //till stående höger
                            Rlock4 = 2;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X -= 1;
                            Block1Y -= 1;
                            Block2Y += 0;
                            Block3Y += 1;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block2X == 9) return;
                            Rlock4 = 3;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X += 1;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 4;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 1;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else 
                        {
                            //till liggande botten
                            if (Block1X == 0) return;
                            Rlock4 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X -= 1;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockI":
                        if (Rlock2 == 1)
                        {
                            //till stående
                            Rlock2 = 2;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 2;
                            Block4Y += 3;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande
                            if (Block1X == 0 || Block1X > 7) return;
                            Rlock2 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y -= 2;
                            Block4Y -= 3;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockO":
                        break;
                }
            }
            if (e.Key == Key.X || e.Key == Key.P)
            {
                switch (block)
                {
                    
                    case "BlockZ":
                        if (Rlock2 == 1)
                        {
                            Rlock2 = 2;
                            Block1X += 2;
                            Block2X += 1;
                            Block3X += 0;
                            Block4X -= 1;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 0;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            if (Block1X == 1) return;
                            Rlock2 = 1;
                            Block1X -= 2;
                            Block2X -= 1;
                            Block3X -= 0;
                            Block4X += 1;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y += 0;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockS":
                        if (Rlock2 == 1)
                        {
                            //till stående
                            Rlock2 = 2;
                            Block1X -= 1;
                            Block2X += 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 0;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande
                            if (Block3X == 1) return;
                            Rlock2 = 1;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y += 0;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockL":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 0) return;
                            //till stående höger
                            Rlock4 = 4;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X += 0;
                            Block1Y -= 1;
                            Block2Y += 0;
                            Block3Y += 1;
                            Block4Y += 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block2X == 9) return;
                            Rlock4 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y -= 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 2;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X -= 0;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y -= 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande botten
                            if (Block1X == 0) return;
                            Rlock4 = 3;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y += 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockJ":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 9) return;
                            //till stående höger
                            Rlock4 = 4;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y -= 1;
                            Block2Y += 0;
                            Block3Y += 1;
                            Block4Y -= 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block2X == 0) return;
                            Rlock4 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X -= 0;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y += 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 2;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y += 0;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande botten
                            if (Block1X == 9) return;
                            Rlock4 = 3;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 0;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y -= 2;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockT":
                        if (Rlock4 == 1)
                        {
                            if (Block1Y == 0) return;
                            //till stående höger
                            Rlock4 = 4;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X += 1;
                            Block1Y += 1;
                            Block2Y += 0;
                            Block3Y -= 1;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 2)
                        {
                            //till liggande botten
                            if (Block2X == 9) return;
                            Rlock4 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 1;
                            Block1Y += 1;
                            Block2Y -= 0;
                            Block3Y -= 1;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else if (Rlock4 == 3)
                        {
                            //till Stående vänste
                            Rlock4 = 2;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X -= 1;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y += 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande botten
                            if (Block1X == 0) return;
                            Rlock4 = 3;
                            Block1X += 1;
                            Block2X -= 0;
                            Block3X -= 1;
                            Block4X -= 1;
                            Block1Y -= 1;
                            Block2Y -= 0;
                            Block3Y += 1;
                            Block4Y -= 1;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockI":
                        if (Rlock2 == 1)
                        {
                            //till stående
                            Rlock2 = 2;
                            Block1X += 1;
                            Block2X += 0;
                            Block3X -= 1;
                            Block4X -= 2;
                            Block1Y += 0;
                            Block2Y += 1;
                            Block3Y += 2;
                            Block4Y += 3;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        else
                        {
                            //till liggande
                            if (Block1X == 0 || Block1X > 7) return;
                            Rlock2 = 1;
                            Block1X -= 1;
                            Block2X -= 0;
                            Block3X += 1;
                            Block4X += 2;
                            Block1Y += 0;
                            Block2Y -= 1;
                            Block3Y -= 2;
                            Block4Y -= 3;
                            Grid.SetColumn(Z1, Block1X);
                            Grid.SetColumn(Z2, Block2X);
                            Grid.SetColumn(Z3, Block3X);
                            Grid.SetColumn(Z4, Block4X);
                            Grid.SetRow(Z1, Block1Y);
                            Grid.SetRow(Z2, Block2Y);
                            Grid.SetRow(Z3, Block3Y);
                            Grid.SetRow(Z4, Block4Y);
                        }
                        break;
                    case "BlockO":
                        break;
                }
            }
        }
        private bool seLås()
        {
            int[] x = { Block1Y, Block2Y, Block3Y, Block4Y };
            int y = x.Max();
            bool z = false;
            if (Block1Y == y && kolG[Block1Y, Block1X])
            {
                z = true;
            }
            if (Block2Y == y && kolG[Block2Y, Block2X])
            {
                z = true;
            }
            if (Block3Y == y && kolG[Block3Y, Block3X])
            {
                z = true;
            }
            if (Block4Y == y && kolG[Block4Y, Block4X])
            {
                z = true;
            }

            return z;
        }
    }
}