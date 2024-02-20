namespace List_Obj
{
    /*
     * List là một loại Generic Collection được sử dụng để thực hiện các thao
     * tác quản lý và xử lý trên một kiểu dữ liệu được xác định thông qua
     * cú pháp khai báo
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khởi tạo List (không nên khai báo)
            // Khai báo
            List<int> list; // rỗng
            // Khởi tạo List
            List<int> list2 = new List<int>();
            // Kích thước của List là không giới hạn, ta có thể truy xuất đến
            // các phần tử trong List thông qua [] tương tự như mảng (array)
            List<string> list3 = new List<string>();
            // <int> hay <string> được gọi là Generic - phải xác nhận kiểu dữ 
            // liệu trước khi muốn sử dụng vì trong List chỉ có thể chứa duy nhất 
            // 1 kiểu dữ liệu chung
            // Các phương thức cơ bản khi sử dụng List
            // Thêm với add và add range
            List<int> listInt = new List<int>();
            listInt.Add(1); listInt.Add(3); listInt.Add(8); listInt.Add(4);
            // Xuât dữ liệu trong List ra 
            Console.WriteLine("Cac phan tu cua List 1");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            List<int> listInt2 = new List<int>();
            listInt2.Add(100); listInt2.Add(1000); 
            Console.WriteLine("\nCac phan tu cua List 2");
            foreach (var item in listInt2)
            {
                Console.Write(item + " ");
            }
            listInt2.AddRange(listInt);
            Console.WriteLine("\nCac phan tu cua List 2 sau khi add List 1");
            foreach (var item in listInt2)
            {
                Console.Write(item + " ");
            }
            // Insert (Thêm nhưng vào 1 vị trí xác định nào đó)
            // Thêm phần tử có giá trị 3333 vào vị trí số 2 trong List 1
            listInt.Insert(2, 3333);
            Console.WriteLine("\nCac phan tu cua List 1 sau khi Insert");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            // Thêm cả ListInt2 vào vị trí thứ 3 của ListInt
            listInt.InsertRange(3, listInt2);
            Console.WriteLine("\nCac phan tu cua List 1 sau khi Insert List 2");
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
            // Sửa - Không có phương thức nào để sửa trực tiếp mà ta cần tự truy xuất đến
            // và gán giá trị cho phần tử đó
            // Xóa với Remove (theo giá trị) và RemoveRange, RemoveAt (Theo vị trí)
            List<string> listString = new List<string>();
            listString.Add("abc"); listString.Add("xyz");
            listString.Add("g43563"); listString.Add("3453");
            listString.Add("(<+>_<+>)"); listString.Add("❤️");
            // Remove At luôn xóa được nếu vị trí nằm trong List
            Console.WriteLine("\nList String");
            foreach (var item in listString)
            {
                Console.Write(item + " ");
            }
            // Xóa phần tử ở vị trí thứ 3
            listString.RemoveAt(3);
            // 
            Console.WriteLine("\nSau khi xóa List String ở vị trí 3");
            foreach (var item in listString)
            {
                Console.Write(item + " ");
            }
            // Xóa giá trị là g43563 (Xóa giá trị này lần đầu tiên)
            listString.Remove("g43563");
            Console.WriteLine("\nSau khi xóa List String giá trị g43563");
            foreach (var item in listString)
            {
                Console.Write(item + " ");
            }

        }
    }
}