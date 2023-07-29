//import java.text.DecimalFormat;
import java.io.PrintStream;
import java.text.DecimalFormat;
import java.util.Scanner;

public class Prog191 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
//        System.out.print("Your first name");
//        String fname = input.next();
 //       System.out.print("Your last name");
//        String lname = input.next();
 //       System.out.println();
 //       System.out.println("Hello \n" + fname + " " + lname);
         // Hàm next() chỉ trả nội dung trước khoảng trắng
         // Hàm nextline() nó sẽ trả về nội dung của 1 bảng, tức là hàng hiện tại 
         
//         System.out.print("Input your full name ");
//         String fullname = input.nextLine();
//         System.out.println();
//         System.out.println("Hello \n" + fullname);

//           int firstNumber, secondNumber, thirdNumber;
//           Scanner scanner = new Scanner(System.in);
//           System.out.println("Nhập số thứ nhất: ");
//           firstNumber = scanner.nextInt();
//           System.out.println("Nhập số thứ hai: ");
//           secondNumber = scanner.nextInt();
//           System.out.println("Nhập số thứ ba: ");
//           thirdNumber = scanner.nextInt();
//           
//           int temp = Integer.max(firstNumber, secondNumber);
//           System.out.println(" Số lớn nhất trong 3 số " + " " + firstNumber + "," + secondNumber + "," + thirdNumber + " là " + Integer.max(firstNumber, secondNumber));
//            Scanner scanner = new Scanner(System.in);
//            DecimalFormat decimalFormat = new DecimalFormat("#.##");
//            System.out.println("Hãy nhập số thứ nhất: ");
//            int firstNumber = scanner.nextInt();
//            System.out.println("Hãy nhập số thứ hai: ");
//            int secondNumber = scanner.nextInt();
//            // decimalformat.format(thuong)
//            // lm tron thuong den 2 chu so thap phan
//            double a = (double) firstNumber / (double) secondNumber ;
//            System.out.println(" firstNumber + secondNumber = " + (firstNumber + secondNumber));
//            System.out.println(" firstNumber - secondNumber = " + (firstNumber - secondNumber));
//            System.out.println(" firstNumber * secondNumber = " + (firstNumber * secondNumber));
//            System.out.printf(" Lm tròn thương đến 2 chữ số thập phân: %.2f", a);

//              float number;
//              Scanner scanner = new Scanner(System.in);
//              System.out.println("Nhap vao 1 so: ");
//              number = scanner.nextFloat();
//              if (number < 5) 
//              {
//                  System.err.println("So vua nhap nho hon 5");
//                  
//              } else if ( number == 5){
//                  System.out.println("So vua nhap bang 5");
//                  
//              }else {
//                  System.out.println("So vua nhap lon hon 5");
//              }
        
//        int a, b;
//        double nghiem;
//        Scanner scanner = new Scanner(System.in);
//        DecimalFormat decimailFormat = new DecimalFormat("#.##");
//        System.out.println("Nhập vào số a: ");
//        a = scanner.nextInt();
//        System.out.println("Nhập vào số b: ");
//        b = scanner.nextInt();
//        System.out.println("Phương trình vừa nhập là " + a + " x + " + b + " = 0 ");
//        if ( a==0 ) {
//            if ( b == 0) {
//                System.out.println("Phương trình có vô số nghiệm ");
//            } else {
//                System.out.println("Phương trình vô nghiệm");
//            }
//        } else {
//            nghiem = (double) -b/a; // ép kiểu
//            System.out.println("Phương trình có nghiệm x = " + decimailFormat.format(nghiem) + ".");
//        }       
        
        // các phương thứuc cảu lớp scanner để lấy dấu vào
        // lớp scanner cung cấp các phương thứuc khác nhau cho phép chúng ta đọc các đầu vào thuộc 
        // phương thức Mô tả
        // nextInt()   Đọc 1 gtri kiểu int.
        // nextFloat() Đọc 1 gtri kiểu float.     ....
        
        
        // toán tử điều kiện 3 ngôi
        // [Biểu thức điều kiện thỏa] ? [ giá trị 1] : [giá trị 2];
        //                             thì              còn k thì
//          Scanner scanner = new Scanner(System.in);
//          System.out.println("Nhập vào 1 số: ");
//          int number;
//          number = scanner.nextInt();
//          String kếtquả = ( number %2 == 0) ? " Số " + number + " là sô chẵn ": " Số " + number + " là số lẻ";
//          System.out.println(kếtquả);


//            int thang;
//            Scanner scanner = new Scanner(System.in);
//            System.out.println("Nhập vào 1 số nguyên từ 1 đến 12: ");
//            thang = scanner.nextInt();
//            switch (thang) {
//                case 1:
//                    System.out.println("Thang 1");
//                    break;
//                case 2:
//                    System.out.println("Thang 2");
//                    break;
//                case 3:
//                    System.out.println("Thang 3");
//                    break;
//                case 4:
//                    System.out.println("Thang 4");
//                    break;
//                default:
//                    System.out.println("Số nhập vào phải trong khoảng 1-12");
//                    
//                    
//            }

         // thực hành: switch case 
         // các tháng 1-3-5-7-8-10 và 12 có 31 ngày.
         // các tháng 4-6-9- và 11 có 30 ngày
         // riêng tháng 2 nếu là năm nhuận thì có 29 ngày, còn không thì có 28 ngày.
         // if ((year % 4 == 0 && year 100  != 0) || (year % 400 == 0))
        
         
        int month;
            Scanner scanner = new Scanner(System.in);
            System.out.println("Nhập vào 1 số nguyên từ 1 đến 12: ");
            month = scanner.nextInt();
            switch (month) {
                // các tháng 1 3 7 5 8 10 và 12 có 31 ngyaf
                case 1: 
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    System.out.println("Tháng " + month + " có 31 ngày.");
                    break;
                // các tháng 4 6 9 11 có 30 ngày
                case 4:
                case 6:
                case 9:
                case 11:
                    System.out.println("Tháng " + month + "có 30 ngày.");
                    break;
                // riêng tháng 2 nếu là năm nhuận thì có 29 ngày, còn k thì có 28 ngày 
                case 2:
                    int year;
                    System.out.println("Mời bạn nhập năm: ");
                    year = scanner.nextInt();
                    if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                        System.out.println("Tháng " + month + " năm " + year + " có 29 ngày.");
                        
                    } else {
                       System.out.println("Tháng " + month + " năm " + year + " có 28 ngày."); 
                    }
                    break;
                default:
                    System.out.println("Nhập tháng không hợp lệ. ");
            }
    }   
}
