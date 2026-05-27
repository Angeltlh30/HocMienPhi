namespace DOTNET0_hocmienphi.repository;


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
            
        public class Class1
        {
        }
        //CODE FIRST | DATABASE FIRST
        //orm
        //Thông thg để tren code co thể làm việc với DB
            //Minnh can ánh xạ (mapping) từ các table lên code để dễ dàng thao tác với dữ liệu

        //DATABASE FIRST
            //Mình làm viecj với 1 DB c sẵn (Create DB = SQL)
            //Vô ta DB, setup field, các mqh, rang buộc trong DB
            //Sau đó o tren code sd cac Driver hoặc thư viện ORM ể kết nối xg DB
            //Ở trên code sẽ ta các class tương ưnứng với các table trong DB
            //Nó sd khi: Khi DB miình c sẵn va dang dc sd trong nhiêều năm. đc join vào dự án Maintain

        //CODE FIRST
            //Mình se kh setuo DB thủ công 
            //Mình sẽ design các database = các class trên code
            //Trên code setup như nào thì DB sẽ tra nhưu vậy
            //Minh setup trên code các field, các relationship
            //Sau do minh ánh xạ cac doạn code do tao ra các table trong DB
            //Cách ánh xạ -> ORM (object relational mapping) - Entity Framework
                //La ng trung gian doc cac class trên code, đọc các atributre, cấu hình
                //sau đó tạo ra các câu lệnh sql de tao bảng
            //Nó cũng kết hop với LINQ
                //Khi sd các hàm Where... translate sang sql
                //vd: .WHERE() -> Select * from table where ...
            //Đc sd khi:
                //Khi mới baắt đầu du án ch có db nao
                //Thiết kế = Code thì nó s đẽ maintain
                    //Dễ nhìn, dễ sửa đổi hơn so với câu lệnh sql

        