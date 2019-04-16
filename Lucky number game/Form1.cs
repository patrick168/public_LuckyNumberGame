using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestNumberAdv2
{
    public partial class Form1 : Form
    {
        static int smallNO, bigNO ;
        static int NO, minNO, maxNO;
        bool again;
        bool initialState;

        //遊戲初始狀態設定
        public void getInitialState()
        {
            Mytitle.Text = "請輸入遊戲的最大數字範圍";
            smallNO = 1;            
            minNO = 1;
           
            again = false;
            initialState = true;
            enterbtn.Text = "確認";
            displayItem(!initialState);
        }

        //建立KeyPress事件
        public Form1()
        {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
           
            InitializeComponent();
        }

        //設定可以按enter輸入
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enter_method();              
            }          
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            enter_method();
        }

       
        private void enter_method()
        {
            //遊戲開始
            if (initialState && !again)
            {
                int maxNOValue;
                             
                if(!Int32.TryParse(tbNO.Text, out maxNOValue))
                    maxNOValue = 100;

                Mytitle.Text = "遊戲開始，請輸入一個數字";
                enterbtn.Text = "確認";
                initialState = false;
                generateLucky(maxNOValue);
                return;
            }
            //按下再一次
            if (again)
            {
                getInitialState();
                again = false;             
                tbNO.Enabled = true;
                tbNO.Text = "";
            }
            else
            {
                //使用者輸入數字時，判斷是否中獎
                if (!Int32.TryParse(tbNO.Text, out int inputNO))
                {
                    if (tbNO.Text.Trim().ToLower() == "r")
                        MessageBox.Show("答案是 " + NO.ToString());
                    else
                    {
                        inputNO = -1;
                        lbRes.Text = "錯誤!請重新輸入!";
                        return;
                    }
                }

                string resno;
                Mathop m1 = new Mathop();
                bool RangeChange = false;

                if (inputNO != NO)
                {

                    if (inputNO < maxNO && inputNO > minNO)
                        RangeChange = true;
                    else
                        return;
                }
                else if (inputNO == NO)
                {
                    finalResult();
                    tbNO.Enabled = false;
                    Answer.Enabled = false;
                    enterbtn.Text = "再一次";
                    again = true;
                }
                m1.a = NO;
                m1.b = inputNO;
                m1.evjudge();
                resno = m1.result;
                lbRes.Text = resno;
                if (RangeChange)
                    lbRange.Text = minNO + "~" + maxNO;
            }
        }
      
        //按下看答案
        private void Answer_Click(object sender, EventArgs e)
        {          
            finalResult();
        }

        public void finalResult()
        {
            Mytitle.Text = "遊戲結束:Lucky Number 是 " + NO.ToString();
            tbNO.Text = NO.ToString();
            Answer.Enabled = false;
            tbNO.Enabled = false;
            enterbtn.Text = "再一次";
            again = true;           
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "終極密碼";
            getInitialState();
            displayItem(!initialState);          
        }

        //隱藏和顯示按鈕
        public void displayItem(bool isShow)
        {
            lbRange.Visible = isShow;
            lbRes.Visible = isShow;
            Answer.Visible = isShow;
        }

        //產生LUCKY NUMBER，最大是maxValue
        public void generateLucky(int maxValue)
        {
            bigNO = maxValue;
            generateLucky();
        }
      
        public void generateLucky()
        {
            displayItem(true);
            Random rnum = new Random();
            minNO = smallNO;
            maxNO = bigNO;
            NO = rnum.Next(minNO + 1, maxNO - 1);
           // this.Text = NO.ToString();  //Display the code in tittle
            lbRange.Text = smallNO + "~" + bigNO;
            enterbtn.Text = "確認";
            lbRes.Text = "開始";
            Answer.Enabled = true;
        }

        //判斷數字太大或太小使用委派
        public delegate void Mathopdlg();

        class Mathop
        {
            public event Mathopdlg ev1, ev2, ev3;
            public int a, b;
            public string result;
            public Mathop()
            {
                ev1 = new Mathopdlg(this.big);
                ev2 = new Mathopdlg(this.small);
                ev3 = new Mathopdlg(this.equal);
            }
            public void evjudge()
            {
                if (b > a)
                    ev1();
                else if (b < a)
                    ev2();
                else
                    ev3();
            }
            public void big()
            {
                result = "太大了";
                maxNO = b;
            }
            public void small()
            {
                result = "太小了";
                minNO = b;
            }
            public void equal()
            {
                result = "命中!";
            }
        }
    }
}