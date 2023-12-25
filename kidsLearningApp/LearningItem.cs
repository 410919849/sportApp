using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kidsLearningApp
{
    public class LearningItem
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class NewsItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class NewsApiResponse
    {
        public List<NewsItem> Articles { get; set; }
    }

    public class news
    {
        public List<LearningItem> 其他運動新聞 { get; set; }
        public List<LearningItem> 肩膀訓練 { get; set; }
        public List<LearningItem> 胸部訓練 { get; set; }
        public List<LearningItem> 手臂訓練 { get; set; }
        public List<LearningItem> 腿部訓練 { get; set; }
        public List<LearningItem> 背部訓練 { get; set; }

        public news()
        {
            胸部訓練 = new List<LearningItem>()
            {
               new LearningItem(){ImageUrl="chest.jpg"},
               new LearningItem(){Name="坐姿機械胸推\n訓練肌肉部位：肱三頭肌、大圓肌、三角肌前束、闊背肌\n\nSTEP 1 準備動作\n坐在訓練機械上，雙手握住訓練把手。\n\nSTEP 2 正式動作\n吸氣時，將雙手往胸口拉近，吐氣時，再緩緩推到初始位置。\n"},
               new LearningItem(){ImageUrl="chest_a.jpg"},
               new LearningItem(){Name="上斜夾胸\n訓練肌肉部位：胸大肌、肱二頭肌、肱三頭肌\n\nSTEP 1 準備動作\n斜躺在45度的訓練板上，雙手握住啞鈴高舉。\n\nSTEP 2 正式動作\n吸氣時，將雙手緩緩打開，吐氣時再回到起始位置。\n"},
               new LearningItem(){ImageUrl="chest_b.jpg"},
               new LearningItem(){Name="臥推\n1.\t平躺於臥推椅上，位置大約為眼睛可以直視槓鈴\n2.\t盡可能在腳掌能紮實的接觸地面的情況下讓腳跟靠近臀部\n3.\t雙手緊握槓鈴讓槓鈴位置落於掌心，握距比肩略寬\n4.\t收肩夾並利用肩膀與臀部微微拱起胸椎\n5.\t採腹式呼吸法，深吸一口氣後，起槓，然後吐氣\n"},

            };

            手臂訓練 = new List<LearningItem>()
            {
              new LearningItem() {ImageUrl = "arm.jpg" },
              new LearningItem() { Name = "槌式彎舉\n訓練肌肉部位：肱肌、肱二頭肌、橈肌\n\nSTEP 1 準備動作\n採站姿，雙腳打比肩寬，雙手握住啞鈴。\n\nSTEP 2 正式動作\n利用手臂力量，將啞鈴彎舉，再吐氣緩緩放下換邊。\n"},
              new LearningItem() { ImageUrl = "arm_a.jpg" },
              new LearningItem() { Name = "仰臥肱三頭肌伸展\n訓練肌肉部位：肱三頭肌、肱二頭肌\n\nSTEP 1 準備動作\n採躺姿，將身體躺在訓練板上，雙手打直握住槓鈴。\n\nSTEP 2 正式動作\n吸氣時，將雙手彎舉槓鈴靠近至臉部，吐氣時，再緩緩回到初始位置。\n"},
              new LearningItem() { ImageUrl = "arm_b.jpg" },
              new LearningItem() { Name = "槓鈴手腕彎舉\n訓練肌肉部位：掌長肌、伸指肌\n\nSTEP 1 準備動作\n採坐姿，將雙腳打開跨坐在訓練椅上，背部向前彎，雙手正向握住槓鈴。\n\nSTEP 2 正式動作\n吸氣時，利用手腕將槓鈴舉起，吐氣時再緩緩放下。\n"},
            };

            背部訓練 = new List<LearningItem>()
            {
               new LearningItem() { ImageUrl = "back.jpg" },
               new LearningItem() { Name = "反手引體向上 REVERSE CHIN-UPS\nSTEP 1 準備動作：雙手與肩同寬，使用反手握法懸吊於單槓上。\nSTEP 2 正式動作：吸氣時，當下巴上台時，同時將胸廓前推，吐氣時，再緩緩下降。\n" },
               new LearningItem() { ImageUrl = "back_a.jpg" },
               new LearningItem() { Name = "引體向上\n訓練肌肉部位：肱二頭肌、肱三頭肌、大圓肌、、大圓肌、闊背肌\n\nSTEP 1 準備動作\n雙手與肩同寬，使用正握法懸吊於單槓上。\n\nSTEP 2 正式動作\n吸氣時，將胸廓上拉前推到訓練桿上，吐氣時，再緩緩下降\n"},
               new LearningItem() { ImageUrl = "back_b.jpg" },
               new LearningItem() { Name = "啞鈴划船\n訓練肌肉部位：三角肌、頭夾肌、斜方肌、闊背肌\n\nSTEP 1 準備動作\n採站姿，雙腳彎曲，雙手握住啞鈴，背部打直。\n\nSTEP 2 正式動作\n吸氣時，將雙手垂直往上舉，保持手肘靠近身體，吐氣時再回到起始位置。\n"},

            };

            肩膀訓練 = new List<LearningItem>()
           {
               new LearningItem { ImageUrl = "shoulder.jpg" },
               new LearningItem { Name = "啞鈴肩推\n肩胛骨要隨動作收縮、不鎖死\n核心腹部收緊、不過度拱腰\n下背不貼死椅背，幫助穩固身體\n" },
               new LearningItem { ImageUrl = "shoulder_a.jpg" },
               new LearningItem { Name = "機械推舉\n訓練肌肉部位：三角肌前束、肱二頭肌、肱三頭肌、胸大肌\n\nSTEP 1 準備動作\n坐在訓練機械上，雙手握住訓練握把，背部打直靠攏。\n\nSTEP 2 正式動作\n吸氣時，將握把上推，吐氣時，再緩緩拉下。\n" },


           };

            腿部訓練 = new List<LearningItem>()
           {
               new LearningItem() { ImageUrl = "leg.jpg" },
               new LearningItem() { Name = "啞鈴單腳深蹲\n訓練肌肉部位：股四頭肌、股二頭肌\n\nSTEP 1 準備動作\n採站姿，將一隻腳往前平舉，一隻手握住啞鈴。\n\nSTEP 2 正式動作\n保持下半身穩定，將膝蓋彎曲下蹲。\n"},
               new LearningItem() { ImageUrl = "leg_a.jpg" },
               new LearningItem() { Name = "硬舉\n手抓重物，雙腳站直與肩同寬，膝蓋、肩膀向後微彎，保持脊椎挺直、腹部緊實、挺胸，緩慢地進行髖關節絞鍊（髖關節的屈曲和伸展動作）。\n當重量靠地面下降，啟動膕膀肌和臀肌力量以抗衡重物向下的拉力，盡可能降低身體，直到腿後側感受到拉扯。\n向前推動臀部回復站姿。重複你所設定的次數和組數。\n"},
               new LearningItem() { ImageUrl = "leg_b.jpg" },
               new LearningItem() { Name = "坐姿屈膝深蹲\n訓練肌肉部位：股四頭肌\n\nSTEP 1 準備動作\n雙腳站穩於訓練機上，雙腿伸直，雙手握住把手，背部靠攏。\n\nSTEP 2 正式動作\n吸氣時，將下半身往下蹲，膝蓋不超出腳尖，吐氣時，再緩緩起身。\n"},


           };
            其他運動新聞 = new List<LearningItem>()
            {


            };
        }
    }
}
