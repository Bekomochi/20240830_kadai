# RPG の道具屋をイメージして、買い物をできるようにする  

## 【要件】  
・アイテムは3種類以上用意する（名称は任意でOK  
・所持金と販売アイテム情報（ID・アイテム名・金額）を画面に表示する  
・ユーザーはアイテムIDを入力してエンターを押すと、アイテムを購入することができる  
・アイテムは繰り返し購入可能  
・購入した所持アイテムは画面に表示する  
・指定したIDのアイテムを買うお金がない場合は購入不可  
・アイテムID入力時、「0」を入力すると買い物終了  

## 【概要】  
変数:int money = 1000;//所持金。購入するごとに減らす。
int number;商品番号。
  
別のクラスで定義したリストを使用し、Main関数でリストにデータを入れる。  
numberに0が入力されるまで、do-while文でループする。  
numberをint.TryParseで整数に変換して条件を判断する。
do-while文の中でif文を使い、入力されたnumberに合わせて計算する。その後、0が入力されるまで、do-while文でループする。  
numberに0が入力された場合、do-whileのループを抜けて終了する。  

## 【使用言語】  
C#
