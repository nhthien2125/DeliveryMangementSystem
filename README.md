IMPORTANT: Làm nếu clone project

1. Mở Command Promt PowerShell chạy lệnh "dotnet restore"
2. Chuột phải project hoặc click Tab "Build" -> Clean Build -> Repair Build
3. Tắt VS, Tìm đến thư mục chứa project, tìm file "bin" và "obj" -> Xóa.
4. Khởi động lại project bằng file .sln

Pull rồi chạy "Update-Database". Dữ liệu mẫu tự thêm để test

Test thì server name=localhost. Connect = SQL Authentication, đặt mật khẩu cho user 'sa' trên máy như trong app.config. rồi tự vào database test
