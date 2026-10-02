# String Manipulation Exercises (Bài tập #9) 

Một ứng dụng Console Application được viết bằng C# để giải quyết 13 bài toán cơ bản và nâng cao về xử lý chuỗi (Strings). Dự án này được phát triển phục vụ cho học phần Cơ sở lập trình tại Trường Đại học Kinh tế TP.HCM (UEH).

## 👨‍💻 Thông tin sinh viên
* **Họ và tên:** Võ Thanh Viễn
* **Ngành học:** Kỹ thuật phần mềm (Software Engineering)
* **Nền tảng:** .NET Console Application (C#)

## 🚀 Danh sách các chức năng (Features)

Chương trình thực hiện tuần tự các nghiệp vụ xử lý chuỗi sau:
1. **Nhập/Xuất:** Nhập một chuỗi từ bàn phím và in ra màn hình.
2. **Đo chiều dài thủ công:** Tính toán chiều dài chuỗi bằng vòng lặp (cố ý không sử dụng thuộc tính `.Length` theo yêu cầu đề bài).
3. **Tách ký tự:** Duyệt và in từng ký tự phân cách bởi khoảng trắng.
4. **Đảo ngược chuỗi:** In chuỗi theo thứ tự từ cuối lên đầu.
5. **Đếm số từ:** Thuật toán nhận diện và đếm chính xác số lượng từ trong chuỗi dựa trên xử lý khoảng trắng.
6. **So sánh chuỗi thủ công:** So sánh 2 chuỗi ký tự bằng vòng lặp lồng nhau (không dùng toán tử `==` hay hàm thư viện).
7. **Thống kê ký tự:** Phân loại và đếm số lượng chữ cái, chữ số, và ký tự đặc biệt.
8. **Nguyên âm & Phụ âm:** Chuẩn hóa chuỗi và đếm số lượng nguyên âm (a, e, i, o, u) so với phụ âm.
9. **Kiểm tra chuỗi con:** Xác định xem một chuỗi (substring) có nằm trong chuỗi gốc hay không.
10. **Tìm vị trí:** Trả về chỉ số (index) xuất hiện đầu tiên của chuỗi con.
11. **Kiểm tra Case:** Nhận diện ký tự nhập vào là chữ IN HOA, chữ in thường hay không phải chữ cái.
12. **Đếm tần suất chuỗi con:** Đếm tổng số lần một chuỗi con xuất hiện lặp lại bên trong chuỗi gốc.
13. **Chèn chuỗi:** Chèn một chuỗi mới vào ngay trước vị trí xuất hiện đầu tiên của một chuỗi con chỉ định.

## 🛠️ Hướng dẫn cài đặt và chạy dự án

1. **Yêu cầu hệ thống:**
   * Cài đặt [Visual Studio](https://visualstudio.microsoft.com/) hoặc [.NET SDK](https://dotnet.microsoft.com/download).
2. **Cách chạy chương trình:**
   * Mở file code bằng Visual Studio.
   * Nhấn `F5` hoặc nút **Start (Play)** để biên dịch và chạy chương trình.
   * Làm theo các câu lệnh hướng dẫn (prompt) hiển thị trên màn hình Console để nhập dữ liệu test nghiệm từ trên xuống dưới.

## 📝 Ghi chú kỹ thuật
* Chương trình xử lý tốt các ngoại lệ khoảng trắng dư thừa bằng hàm `char.IsWhiteSpace()`.
* Đảm bảo tính bất biến của chuỗi (immutable strings) trong thuật toán đếm nguyên âm bằng cách gán đè `s = s.ToLower();`.
* Bảng mã Console được thiết lập `Encoding.UTF8` ở hàm Main để hỗ trợ nhập và hiển thị tiếng Việt có dấu đầy đủ.
