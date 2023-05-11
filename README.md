# Project-LTUD
![image](https://github.com/Dat20021512/Project-LTUD/assets/90948372/f3d25482-24d8-44eb-b0f7-9d9484ca5a46)
CÁC CHỨC NĂNG CỦA ỨNG DỤNG
I.	File
-	Open file: Mở ảnh cần chỉnh sửa/xử lý
-	Save: Lưu ảnh đã chỉnh sửa ở box 2 sang 1 ảnh mới (.jpg)
-	Delete: Xóa ảnh ở 2 box
-	Exit: Tắt phần mềm
II.	Edit
-	Rotate: Có 2 nút xoay trái và xoay phải (xoay trái: giảm 90 độ, xoay phải: tăng 90 độ, đến giá trị -360/360 độ thì sẽ đặt về lại = 0)
-	Flip: Lật ảnh theo trục x
-	Crop: Cắt ảnh theo con trỏ chuột
III.	Filter
	EDGE: Phát hiện cạnh bằng hàm Canny sử dụng opencv, sử dụng sẽ hiện lên ảnh kết quả ở box 2 
IV.	Covert
-	Gray: Chuyển màu ảnh sang màu xám, sử dụng sẽ hiện lên kết quả ở box 2
-	Negative: Chuyển đổi âm bản, sử dụng sẽ hiện lên kết quả ở box 2
V.	Increase
-	Brightness: Chỉnh độ sáng (max 255)
-	Constrast: Chỉnh độ tương phản
VI.	Split
Tách ảnh RGB thành 3 ảnh, tương ứng với 3 thành phần R, G, B
