
package collection;

import java.util.ArrayList;

public class TestArrayList {
    public static void main(String[] args) {
//        ArrayList<Integer> arrListInt = new ArrayList<>();
//        arrListInt.add(1);
//        arrListInt.add(0);
//        arrListInt.add(2);
//        arrListInt.add(3);
//        arrListInt.set(3,204);
//        System.out.println(" Các phần tử trong arrList: ");
//        for (int i:arrListInt) {
//            System.out.println( i + " \t ");
//        }

          // kiểu String 
          ArrayList<String> arrayList = new ArrayList<>();
          arrayList.add("Xin chào");
          arrayList.add("Hello");
          arrayList.add("Ciao");
          System.out.println("Các phần tử trong arrayList");
          for (int i = 0; i < arrayList.size(); i++) {
              System.out.println(arrayList.get(i) + "\t");
          } 
          
    }
}
