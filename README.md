1. 專案截圖
![image](https://github.com/OuO1234567888/1151VR-HW3-412262462-ysliu/blob/main/1151VR-HW3-%E6%88%AA%E5%9C%96.png)

2. github連結
https://github.com/OuO1234567888/1151VR-HW3-412262462-ysliu

3. youtube連結
https://youtube.com/shorts/bC5TaCdabqA?feature=share

4. 說明製作流程和相關操作
將圖片放入場景中，在指針上加上Box Collider2D並勾選isTrigger，在輪盤建立三個子物件分別加上Box Collider2D，在輪盤上加上Rigidbody2D，撰寫Roulette.cs來控制輪盤轉動與停止，使用OnTriggerEnter2D在輪盤邊界碰到指針時撥放音效。

note: Rigidbody要掛在父物件上才能在子物件的 Collider 進入其他 Trigger 時，觸發父物件身上的 OnTriggerEnter。
