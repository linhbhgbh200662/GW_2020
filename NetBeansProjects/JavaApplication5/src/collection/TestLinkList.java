
package collection;

import java.util.LinkedList;

public class TestLinkList {
    public static void main(String[] args) {
        LinkedList<Integer> linkedList = new LinkedList<>();
        linkedList.add(1);
        linkedList.add(0);
        linkedList.add(2);
        linkedList.add(3);
        linkedList.remove(1);
        System.out.println("Các phần tử trong Linked List: ");
        for (int i: linkedList) {
            System.out.println( i + "\t"); 
        }
    }
}
