namespace DOTNET0_hocmienphi.repository;

public class Class1
{
}

//Kiến trúc 3 Layers  
    //Tầng API: chiu trách nhiệm khai bao các endpoint, nhận request, trả về response
    //         config hệ thống
    //          API gọi tới Service
    //Tầng Service: chịu trách nhiêm xử lý nghiệp vụ
    //              tương tác voi tầng Repository để lấy dữ liệu, xử lý nghiệp vụ, trả về kết quả cho tầng API
    //Tầng Repository: chịu trách nhiệm tuogtacsc với database, cấu hình những thứ liên quan tới db
    
    //VD: có 1 req là login vào hệ thống
        //Tang API: muốn login phải chui vô: POST/api/auth/Login
            //Nhận request body {email: "Tan", password: "123"}
            //Gọi tới Service để xử lý nghiệp vụ login
            //Xử ly login: LoginHandler(email, password)
            //Lúc này ham logim trong Service sẽ chạy như sau:
                //Kiem tra email | ng dung co tồn taij trong db kh
                //ng dùng này bị banned hay kh
                //Nếu lỗi -> trả lỗi
                //Neu kh -> trả ve Token đăng nhập
        //Tầng Service lúc này gọi xg Repository ham
            //GetUserByEmail(email)
            //Hàm này chạy câu lenh SQLể lấy thong tin ng dung ra khoi db