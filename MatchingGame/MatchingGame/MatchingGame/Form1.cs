using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //参照変数
        //1つ目にクリックされたコントロール
        //プレーヤがまだラベルをクリックしないときはnull
        Label firstClicked = null;

        //2つ目にクリックされたコントロール
        Label secondClicked = null;



        //アイコンのランダム表示に使う
        Random random = new Random();

        //それぞれのアイコンが2回表示される
        List<string> icons = new List<string>()
        {
            //リストに格納されるstringたち
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"

        };

        //タイマーの定義(経過時間)
        int timePassing;

        

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
            timePassing = 0;
            
            timer2.Start();
        }
        //各ラベルにリストの中のアイコンをランダムに割り当てる

        private void AssignIconsToSquares()
        {
            //tableLayoutPanelは16個のラベルを持つ
            //アイコンのリストは16個のアイコンを持つ
            //表示するアイコンはリストからランダム
            //に持ってラベルに追加する
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    //アイコンの色を背景と一緒にすることで見えなくするが存在はする
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }



            }
        }

        //このイベントハンドラは全てのラベルがクリックされるというイベントで動く
        private void label_Click(object sender, EventArgs e)
        {
            //ハンドラメソッドはどのラベルがクリックされたか知る必要がある
            //このため、クリックされたラベルコントロールにsenderとつける

            if (timer1.Enabled == true)
                //Enabledプロパティがtrueだったら実行停止
                return;

       
            Label clickedLabel = sender as Label;

            //secondClickedがnullでないとおかしい(リセットしている)
            //nullチェック、違ったら実行停止
            if (secondClicked != null)
                return;

           

            if (clickedLabel != null)
            {
                //クリックしたアイコンが黒の場合、プレーヤは見えるため、
                //もう一度同じものをクリックしない
                if (clickedLabel.ForeColor == Color.Black)
                   //メソッドの実行を停止
                    return;

                //firstClickがnullだったら、最初のアイコン
                //参照変数にクリックされたラベルを入れ、色変える
                if (firstClicked == null) 
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                //既にクリックされたもの、1つ目のクリックではない
                //つまり、2つ目のクリックし、表示させる
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                //プレーヤが全部当てたかチェック
                CheckForWinner();



                //プレーヤのクリックしたアイコンが2つマッチした場合
                //他のアイコンをクリックするように黒く保持しリセットする
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                //プレーヤが異なる2つのアイコンをクリックしたら
                //タイマーを開始する
                timer1.Start();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //タイマーをストップさせる
            timer1.Stop();

            //2つのクリックされたアイコンを
            //背景と一緒の色にして、隠す
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            //firstClickedとsecondClickedをリセット
            //リセットすることでプログラムは1つ目のクリックと認識する
            firstClicked = null;
            secondClicked = null;        
        }

        //プレーヤが勝利したか確認するメソッド
     
        private void CheckForWinner()
        {
            //全てのアイコンが一致しているか確認する
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    //アイコンが背景と同じ色（隠れ）だったら実行停止
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    
                        return;
                    
                }
            }
            MessageBox.Show("おめでとう！！ぜんぶそろったね！");
            timer2.Stop();
            MessageBox.Show(timePassing + "seconds");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timePassing = timePassing + 1;
           // timeLabel.Text = timePassing + "seconds";
           // timer2.Stop();
           
        }

       
    }
}


 

