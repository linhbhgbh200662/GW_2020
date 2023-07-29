

import java.util.Scanner;

public class Testt {
//public static void main(String[]args) {
//    int number, sum = 0;
//    Scanner sc = new Scanner(System.in);
////    while(sum < 5 ) {
////        System.out.println(" Nhập vào số nguyên bất kỳ ");
////        number = sc.nextInt();
////        sum+=number;
////    }
////    System.out.println(" Tổng các số nguyên vừa nhập = " + sum);
//      
//      do{
//        System.out.println(" Nhập vào số nguyên bất kỳ "); 
//        number = sc.nextInt();
//        sum+=number;
//      }while (sum < 10);
//      System.out.println(" Tổng các số nguyên vừa nhập = " + sum);
//}
    // khai báo mảng và cấp phát bộ nhớ cho mảng
    // cách 1:
    //[kiểu dữ liệu] [][] tên mảng[][]=new[kiểu dữ liệu] [số dòng][số cột];
    //int number[][]=new int[2][3];

    //cách 2:
    //[kiểu dữ liệu] [][] tên mảng[][]=new[kiểu dữ liệu] [số dòng][số cột];
    //string[][]A=new string[3][5];

    // khái báo một mảng 2 chiều có 3 dòng và 2 cột
    // int diem[][]={{1,2},{3,4},{5,6}};
    //system.out.println(" Phần tử nằm ở dòng 2 và cột 1 trong mảng diểm là" _diêm[2][1]);
//public static void main(String[]args) {
//    int soDong, soCot;
//    Scanner sc = new Scanner(System.in);
//    System.out.println("Nhập vào số dòng của mảng");
//    soDong=sc.nextInt();
//    System.out.println("Nhập vào số cột của mảng");
//    soCot=sc.nextInt();
//    
//    int [][] arr= new int[soDong][soCot];
//    for(int i=0; i<soDong; i++) {
//        for(int j=0; j<soCot; j++) {
//            System.out.println("Nhập phần tử thứ["+i+","+j+"]:");
//            arr[i][j] = sc.nextInt();
//        }
//    }
//    // hiển thị các phần tử trong mảng vừa nhập:
//    System.out.println("Mảng vừa nhập: ");
//    for(int i=0; i<soDong; i++){
//        for(int j=0; j<soCot; j++){
//            System.out.println(arr[i][j]+"\t");
//        }
//    //. sau khi viết xong 1 dòng thì xuống hàng
//    System.out.println("\n");
//    
//    /*for(int i=0; i<soDong; i++){
//        for(int j=0; j<soCot; j++){
//            System.out.println(arr[i][j]+"\t");
//            if(i == j){
//                tong = tong + arr[i][j];
//            }
//        }
//    }*/
//}

    
// Thưcj hành 
public static void main(String[]args) {
    int n; // bậc của ma trận vuông
    int sum=0;
    Scanner scanner = new Scanner(System.in);
    System.out.println("Nhập vào bậc của ma trận: ");
    n = scanner.nextInt();
    int arr[][] = new int[n][n];
    System.out.println("Nhập các phần tử cho ma trận: ");
    for(int i=0; i<n; i++){
        for(int j=0; j<n; j++){
            System.out.print("Arr["+i+"]["+j+"]=");
            arr[i][j] = scanner.nextInt();
        }
    }
    System.out.println("Ma trận Arr vừa nhập: ");
    for(int i=0; i<n; i++){
        for(int j=0; j<n; j++){
            System.out.println(arr[i][j] + "\t");
        }
        System.out.print(arr[i][j] + "\t");
    }
    // các phần tử nằm trên đường chéo chính
    //là các phần tử có chỉ số dòng = chỉ số cột
    for(int i=0; i<n; i++){
        for(int j=0; j<n; j++) {
            // ktra nếu i == j ( có chỉ sô dòng và cột bằng nhau) thì mới tính tổng
            if(i == j){
                sum+=arr[i][j];
            }
        }
            
    }
    System.out.println("Tổng các phần tử nằm trên đường chéo chính = " + sum);
    
}
         
    
    
}


/* switch(biểu thức)
case giá trị 1:
    lệnh 1;
    break;
case giá trị 2:
    lệnh 2;
    break;
....
case giá trị n:
    lệnh n;
    break;
[default: lệnh 0;]
}*/

/* while( điều kiện lặp){
  // các lệnh
}
//lệnh kế tiếp
*/

/*do{
//các lệnh
}while(điều kiện lặp);
//lệnh kế tiếp
*/




