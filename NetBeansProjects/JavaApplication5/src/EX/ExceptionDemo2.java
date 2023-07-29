
package EX;

public class ExceptionDemo2 {
    public static void main(String[] arg) {
        //ArrayIndexOutOfBounds
//        try {
//            int a[] = new int[10];
//            a[11] = 9;
//        }
//        catch (ArrayIndexOutOfBoundsException e) {
//            System.out.println("ArrayIndexOutOfBoundsException");
//        }
          //NumberFormatException
          try {
          int num = Integer.parseInt("ABC");
          System.out.println(num);
          }
          catch (NumberFormatException e) {
              System.out.println("NumberFormatException");
          }
          finally {
              System.out.println("Finally block");
          }
    }
}
