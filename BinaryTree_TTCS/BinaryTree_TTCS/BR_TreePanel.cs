using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using TreeColections;

namespace BinaryTree_TTCS
{
    public partial class BR_TreePanel : UserControl
    {
        #region Properties

        const int RADIUS = 20;// Bán kính
        const int DIAMETER = RADIUS * 2; //Đường kính
        const int HOR_DISTANCE = 80; //Chiều ngang
        const int VER_DISTANCE = 100;// Chiều dọc

        Pen _penNormal;
        Pen _penHighLight;
       // Brush _brush;
        Font _font;

        BrTreeNode<int> _Tree;

        int _count;   //đếm số lượng phần tử trong mảng
        float _leftRoot;
        float _minLeft;
        float _maxLeft;
        float _ratio;//Tỉ lệ

        Graphics _g;

        Queue<int> _queue;//Hàng đợi

        public int _Count()
        {
            return _count;
        }

        #endregion
        public BR_TreePanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);

            _penNormal = new Pen(Color.Blue, 2);
            _penHighLight = new Pen(Color.Red, 3);
            _font = new Font("Arial", 18);
            _Tree = new BrTreeNode<int>(50);

        }

        public void GenerateTree(int size, int min, int max)
        {
            if (min >= max || (max - min < size))
            {
                MessageBox.Show("Invalid parameters!", "OMG");
                return;
            }

            _queue = null;

            _Tree.Clear();//xóa danh sách cũ

            Random rnd = new Random();

            int[]  arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max);//Random một số thuộc về một đoạn giá trị
            _Tree.Add(arr);

            //Gọi hàm để vẽ cây
            BeginDraw(true);
        }
        
        private void BeginDraw(bool resetAll) 
        {
            _count = _Tree.Count;
            // Lấy khoảng cách giữa các node
            _ratio = (_Tree.Count * 500) / this.Width;// +RADIUS / this.Width;

            if (resetAll)//true
            {
                if (pictureBox1.Image != null)
                   pictureBox1.Image.Dispose();

                _leftRoot = pictureBox1.Width ;
                _minLeft = _leftRoot;
                _maxLeft = _leftRoot;

                using (Graphics g = pictureBox1.CreateGraphics())//khởi tạo đồ họa
                {
                    CalculateSize(g, _leftRoot, _Tree.Root);
                }
                // Chỉnh kích thước hiển thị khi số lượng các phần tử nhỏ
                _leftRoot -= _minLeft;
                if (_Tree.Count < 3)
                    _leftRoot += 100;
                _maxLeft -= _minLeft;
                _minLeft = 0;
                _leftRoot += 100;
                _maxLeft += 250;
            }
            //Khởi tạo một phiên bản mới của lớp Bitmap với kích thước được chỉ định.
             Image img = new Bitmap((int)_maxLeft, (_Tree.GetHeight() + 1 ) * VER_DISTANCE + 100);

            if (_g != null)
            {
                _g.Dispose();//Giải phóng đối tượng đồ họa
                pictureBox1.Image.Dispose();
            }

            pictureBox1.Image = img;// new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _g = Graphics.FromImage(pictureBox1.Image);
            _g.SmoothingMode = SmoothingMode.AntiAlias;//Khử răng cưa

            DrawTreeNode(_g, new PointF(_leftRoot, DIAMETER * 2), _Tree.Root, true);
        }
       
        private void DrawTreeNode(Graphics g, PointF p, BinaryTreeNode<int> node, bool highlight)
        {
            if (node != null)
            {
                string text = node.Value.ToString();
                SizeF size = g.MeasureString(text, _font);//Đo chuỗi được chỉ định

                float ellipseWidth = RADIUS + size.Width;
                float ellipseHeight = RADIUS + size.Height;

                float left = p.X - ellipseWidth / 2;
                float top = p.Y - ellipseHeight / 2;

                Pen pen = _penNormal;

                //Tính toán vẽ node trái
                if (node.HasLeftChild)
                {
                   // khai báo hai biến lấy giá trị là tọa độ điểm đã truyền vào
                    PointF p1 = p;
                    PointF p2 = p;
                    //p1.X = left + ellipseWidth / 2;

                    p2.X -= (node.Value - node.LeftChild.Value) * _ratio;
                    p2.Y += VER_DISTANCE;

                    bool hlight = false;

                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.LeftChild.Value)//Peek lấy phần tử nhưng ta không xóa
                        {
                            //Trả về giá trị của đối tượng tại vị trí đầu trong Queue(phần tử thêm
                            //vào đầu tiên) đồng thời xoá phần tử khỏi Queue.
                            _queue.Dequeue(); 

                            pen = _penHighLight;
                            hlight = true;
                        }
                    }
                    g.DrawLine(pen, p1, p2);// vẽ đường nối các node lại
                    DrawTreeNode(g, p2, node.LeftChild, hlight);
                    //if (p2.X < _minLeft)
                    //    _minLeft = p2.X;
                    //if (p2.X > _maxLeft)
                    //    _maxLeft = p2.X;
                }
                //Tính toán vẽ node phải
                if (node.HasRightChild)
                {
                    // khai báo hai biến lấy giá trị là tọa độ điểm đã truyền vào
                    PointF p1 = p;
                    PointF p2 = p;
                    //p1.X = left + ellipseWidth / 2;

                    p2.X += (node.RightChild.Value - node.Value) * _ratio;
                    p2.Y += VER_DISTANCE;

                    pen = _penNormal;
                    bool hlight = false;
                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.RightChild.Value)//Peek lấy phần tử nhưng ta không xóa
                        {
                            //Trả về giá trị của đối tượng tại vị trí đầu trong Queue(phần tử thêm
                            //vào đầu tiên) đồng thời xoá phần tử khỏi Queue.
                            _queue.Dequeue();

                            pen = _penHighLight;
                            hlight = true;
                        }
                    }
                    g.DrawLine(pen, p1, p2);// vẽ đường nối các node lại
                    DrawTreeNode(g, p2, node.RightChild, hlight);
                    //if (p2.X < _minLeft)
                    //    _minLeft = p2.X;
                    //if (p2.X > _maxLeft)
                    //    _maxLeft = p2.X;
                }
                
                pen = highlight ? _penHighLight : _penNormal;
                //Xác định màu tô lên
                SolidBrush lightBrush = new SolidBrush(Color.LightCyan);
                g.FillEllipse(lightBrush, left, top, ellipseWidth, ellipseHeight);
                //Vẽ  hình elip được xác định bởi một hình chữ nhật giới hạn
                //được chỉ định bởi các tọa độ cho góc trên bên trái của hình chữ nhật,
                //chiều cao và chiều rộng.
                g.DrawEllipse(pen, left, top, ellipseWidth, ellipseHeight);
                //
                g.DrawString(text, _font, Brushes.Black, left + RADIUS / 2, top + RADIUS / 2);

            }
        }

        private void CalculateSize(Graphics g, float left, BinaryTreeNode<int> node)
        {
            if (node != null)
            {
                string text = node.Value.ToString();
                SizeF size = g.MeasureString(text, pictureBox1.Font);

                float x = left - (RADIUS + size.Width) / 2;

                if (node.HasLeftChild)
                {
                    float p2 = x - Math.Abs(node.Value - node.LeftChild.Value) * _ratio;
                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;

                    CalculateSize(g, p2, node.LeftChild);
                }
                if (node.HasRightChild)
                {
                    float p2 = x + Math.Abs(node.RightChild.Value - node.Value) * _ratio;

                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;

                    CalculateSize(g, p2, node.RightChild);
                }


            }
        }

        /*--------------------------*/

        private void BeginDraw1()
        {
            BeginDraw(false);
        }

        public void SearchNode_LNR(int i)
        {
            List<int> list = _Tree.InOrderTraverse();//duyệt LNR
            _queue = _Tree.FindPath(list[i]);
            textBox1.Text = list[i].ToString();
            BeginDraw1();
            Thread.Sleep(2000);
        }
        public void SearchNode_NLR(int i)
        {
            List<int> list = _Tree.PreOrderTraverse();//duyệt NLR
            _queue = _Tree.FindPath(list[i]);
            textBox1.Text = list[i].ToString();
            BeginDraw1();
            Thread.Sleep(2000);
        }
        public void SearchNode_LRN(int i)
        {
            List<int> list = _Tree.PostOrderTraverse();//duyệt LRN
            _queue = _Tree.FindPath(list[i]);
            textBox1.Text = list[i].ToString();
            BeginDraw1();
            Thread.Sleep(2000);
        }

        public void InOrderTraverse()
        {
            //textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBoxOut.Clear();
            StringBuilder str = new StringBuilder("In-Order: ");
            List<int> list = _Tree.InOrderTraverse();//duyệt LNR
            
            list.ForEach(i => str.Append(i).Append(", "));
            textBoxOut.Text = str.ToString().Remove(str.Length - 2);
            list.Clear();
            list = null;
        }
        public void PreOrderTraverse()
        {
            //textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBoxOut.Clear();
            StringBuilder str = new StringBuilder("Pre-Order: ");
            List<int> list = _Tree.PreOrderTraverse();
            list.ForEach(i => str.Append(i).Append(", "));

            textBoxOut.Text = str.ToString().Remove(str.Length - 2);
            list.Clear();
            list = null;
        }
        public void PostOrderTraverse()
        {
            //textBox1.Enabled = false;
            textBox1.ForeColor = Color.Red;
            textBoxOut.Clear();
            StringBuilder str = new StringBuilder("Post-Order: ");
            List<int> list = _Tree.PostOrderTraverse();
            list.ForEach(i => str.Append(i).Append(", "));

            textBoxOut.Text = str.ToString().Remove(str.Length - 2);
            list.Clear();
            list = null;
        }
    }
}
