
import static java.lang.StrictMath.PI;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Test {

    public static final int HOUR = 24;
    public static final String CHUOI = "Hi everybody";
    public static final float Pr = 3.14f; // khái báo hằng số

    public static void main(String[] args) {

////        Scanner sc = new Scanner(System.in);
//        System.out.println("Enter user name: ");
//        String userName = sc.nextLine();
//        // viết chương trình nhập vào userName, password
//        // vs check nếu nhập đúng thì hiển thị ...; nhập sai thì ...
//        
//        // phương thức equals() so sánh hai chuỗi đưa ra dựa trên nội dungcuar chuỗi.
//        //nếu 2 cuỗi khác nhau thì nó trả về false. nếu hai chuỗi bằng nhau nó trả về true
//        //System.out.println("UserName: ");
//        System.out.println("Password: ");
//        String password = sc.nextLine();
//        
//        if("Name".equals(userName) && "mật khẩu".equals(password)) 
//        {
//            System.out.println("User successfully logged in");
//        }
//        else {
//                System.out.println("Invaild userName or password");
//                }
//          String chuoiA = "";
//          String chuoiB = "Hello";
//          System.out.println("Chuỗi rỗng =" + chuoiA);
//          
//          String chuoiC;
//          Scanner scanner = new Scanner(System.in);
//          System.out.println("Input: ");
//          chuoiC = scanner.nextLine();
//          System.out.println("Length = " + chuoiC.length());
//          // concat(): nối chuỗi
//          String chuoi1 = "Good", chuoi2 = " afternoon";
//          String chuoi3 = chuoi1.concat(chuoi2);
//          System.out.println(chuoi3);
//          //trim(): loại bỏ khoảng trắng thừa
//          String chuoi = new String ("Xin chào mùa hè");
//          //phương thức trim() trong java string.
//          // đây là 1 phương thức được sử dụng để loại bỏ tất cả các khoảng trắng ở đầu và cuối
//          System.out.println(chuoi.trim());
//          
//          //muốn xóa toàn bộ khoảng trắng thừa
//          System.out.println(chuoi.replaceAll("\\s\\s+", " ").trim());
//          
//          //charAt: trả về ký tự ( có chỉ số là index) trong chuỗi
//          char ch = chuoi.charAt(4);
//          System.out.println(ch);
//          
//          // compareTo
//          int res;
//          String chuoiA1 = "Java Core";
//          String chuoiA2 = "Java Core";
//          res = chuoiA1.compareTo(chuoiA2);
//          if (res == 0) {
//              System.out.println("Chuỗi bằng nhau " + chuoiA1 + " = " + chuoiA2);
//                    
//            }
//          else {
//              System.out.println("Hai chuỗi không bằng nhau");
//            }      
//            String chuoi;
//            char kyTu;
//            int count = 0;
//            System.out.println("Nhập vào 1 chuỗi: ");
//            Scanner sc = new Scanner(System.in);
//            chuoi = sc.nextLine();
//            
//            System.out.println("Nhập vào 2 ký tự: ");
//            kyTu = sc.next().charAt(0);
//            
//            for(int i=0; i<chuoi.length(); i++) {
//                if(kyTu == chuoi.charAt(1)) {
//                    count++;
//                    
//                }
//            }
//            System.out.println("Số lần xuất hiện của ký tự là " + count);
        // thực hành: đếm số ký tự in thường, in hoa, số của 1 chuỗi được nhập từ bàn phím
//            String chuoi;
//            int soTuVietHoa = 0, soTuVietThuong = 0, soChuSo = 0;
//                System.out.println("Nhập vào 1 chuỗi ");
//                Scanner scanner = new Scanner(System.in);
//                chuoi = scanner.nextLine();
//                
//                for (int i = 0; i<chuoi.length(); i++) {
//                    if(Character.isUpperCase(chuoi.charAt(i))) {
//                        // phương thức isUpperCase() trong java xác định có hay k giá trị char đã xác định là chữ hoa.
//                        // trả về true nếu character đã truyền thực sự là chữ hoa.
//                        // charAt: trả về ký tự (có chỉ số là index) trong chuỗi.
//                        soTuVietHoa++;
//                    }
//                    // if (chuoi.charAt(i) >= 'a' && chuoi.charAt(i) <= 'z'){
//                    if(Character.isLowerCase(chuoi.charAt(i))) {
//                        
//                        soTuVietThuong++;
//                    }
//                    if(Character.isDigit(chuoi.charAt(i))) {
//                        soChuSo++;
//                    }
//                }
//                System.out.println("Số ký tự viết hoa: " + soTuVietHoa + " Số ký tự viết thường: " + soTuVietThuong + " Số chữ số: " + soChuSo);
        // làm tròn số trong java
//                  Scanner sc = new Scanner(System.in);
//                  System.out.println("Input: ");
//                  
//                  double num = sc.nextDouble();
//                  //%.3f làm tròn 3 chữ số thập phân 
//                  System.out.format("Số %f khi được làm được làm tròn là: %.3f", num,num);
//                  
//                  // cách 2:
//                  DecimalFormat df = new DecimalFormat("#.##");
//                  System.out.println("\n Cách 2: So" + num + " được làm tròn là: " + df.format(num));
//                  
//                  int[] a = new int[] {3,9,6,8,5};
//                  char[] kyTu = new char[] {'a', 'b', 'c', 'd', 'e'};
//                  System.out.println("Ký tự tại vị trí thứ 2 trong mảng là: " + kyTu[2]);
//                  
//                  int size, temp;
//                  Scanner sc = new Scanner(System.in);
//                  System.out.println("Nhập số phần tử của array: ");
//                  size = sc.nextInt();
//                  
//                  int[] array = new int[size];
//                  for(int i=0; i<size; i++) {
//                      System.out.println("Nhập vào phần tử thứ " + i );
//                      array[i] = sc.nextInt();
//                  }
//                  for(int i=0; i<size; i++) {
//                      System.out.println("Phần tử thứ " + i + " : " + array[i]);
//                  }
//                  
//                  
//                // sắp xếp thứ tự từ nhỏ đến lớn
//                for (int i = 0; i<size; i++) {
//                    for (int j = i + 1; j <= size - 1; j++) {
//                        if (array[j] < array[i]) {
//                            temp = array[i];
//                            array[i] = array[j];
//                            array[j] = temp;
//                        }
//                    }
//                }
//                System.out.println("Mảng đc sắp xếp: ");
//                for (int i = 0; i < size; i++) {
//                    System.out.println(array[i] + "\t");
//                }
//        System.out.println(CHUOI);
//        System.out.println("Một ngày có " + HOUR + "h");
//
//        int first = 5, second = 7;
//        int result = first++ + ++second - 8;
//        System.out.println("First = " + first);
//        System.out.println("Second = " + second);r
//        System.out.println("Third = " + result);
          
          // Excercise
          // công thứuc tính thể tích khối cầu: V = 4/3(n.r^3)
          // diện  tích mặt cầu: S = 4pi.R^2
          //trong đó R là bán kính khối cầu ( mặt cầu, hình cầu)
          Scanner scanner = new Scanner(System.in);
          
          // khai báo lớp DecimalFormat dùng để định dạng số
          DecimalFormat decimalFormat = new DecimalFormat("#.##");
          System.out.println("Nhập vào bán kính hình cầu (r > 0)");
          float r = scanner.nextFloat();
          
          float area = (float) (4 * PI * r * r);
          System.out.println("Diện tích hình cầu = " + decimalFormat.format(area));
          
          // luwu ý ép kiểu kết quả của 4/3 về số thực. 
          float voi = (float) 4/3 * PI * r * r * r;
          System.out.println("Thể tích hình cầu = " + decimalFormat.format(vol));
     
    }
}
