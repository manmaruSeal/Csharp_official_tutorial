using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideo
{
    public partial class RentalVideo : Form

        
    { 
        //レンタル開始日時と終了日時
        DateTime start;
        DateTime end;

        //基本料金と基本料金＋延滞料金
        int money ;
        int moneyAll;

      

        //ビデオタイプ
        string videoType;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RentalVideo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moneyCal_Click(object sender, EventArgs e)
        {
            
            //開始/終了日時の取得
            start = DataTimepicker1.Value;
            end = DataTimepicker2.Value;

            //レンタル期間の計算
            TimeSpan span = end - start;
           
            //一応、期間の確認
            //MessageBox.Show(span.ToString());

            //ビデオの種類を取得
            if (newVideo.Checked == true)
            {
                videoType = "new";
            }
            if (oldVideo.Checked == true)
            {
                videoType = "old";
            }
           
            //料金計算のメソッド呼び出し
            moneyAll = videoTimeMoney(span,videoType);

            if((money == moneyAll)&&(moneyAll>0))
            {
                rental.Text = "レンタル料金 " + money.ToString() + "円";
                plus.Text = "延滞料金 0円";
            }
            else if (moneyAll>money)
            {
                int plusmoney = moneyAll - money;

                rental.Text = "レンタル料金 " + money.ToString() + "円";
                plus.Text= "延滞料金 " + plusmoney.ToString() + "円";

            }
            else
            {
            rental.Text = "レンタル期間を確認してください。";
            plus.Text = "日付がおかしいです。";
            }
            

           
        }

      

        //レンタル料金を計算するメソッド
        private int videoTimeMoney(TimeSpan time,string video)
        {

            //延滞料金
            int plusmoney = 0;

            //延滞期間
            TimeSpan timeSpan = time;
            TimeSpan oneWeek = new TimeSpan(7, 0, 0, 0);
            TimeSpan plusSpan = timeSpan - oneWeek;

            //ビデオのtype
            string videotype = video;

            //期間0日と1日
            TimeSpan time0 = new TimeSpan(0, 0, 0, 0);
            TimeSpan time1 = new TimeSpan(1, 0, 0, 0);

            //一週間以内、0日より長いとき
            if ((timeSpan<=oneWeek)&&(timeSpan>time0))
            {
                if (video == "new")
                    money =1000;
                if (video == "old")
                    money = 500;
            }

            //1週間より長いとき
            else if (timeSpan>oneWeek)
            {
                if (video == "new")
                {
                    
                    while (plusSpan>time0)
                    {
                        
                        money = 1000;
                        plusmoney += money * 1 / 10;
                        plusSpan = plusSpan - time1;
                            
                    }
                }
                if (video == "old")
                {

                    while (plusSpan > time0)
                    {
                        
                        money = 500;
                        plusmoney += money * 1 / 10;
                        plusSpan = plusSpan - time1;

                    }
                }


            }
            else
            {
                money = 0;
                plusmoney =0;
            }
           


            return money+plusmoney ;
        }

    }
}
