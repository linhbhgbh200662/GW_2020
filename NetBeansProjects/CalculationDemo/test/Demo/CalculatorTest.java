
package Demo;

import org.junit.Test;
import static org.junit.Assert.*;

public class CalculatorTest {
    
    Calculator cal;
    public CalculatorTest() {
        cal = new Calculator();
    }

    @Test
    public void testAdd() {
        int rs = cal.add(4,5);
        int expected = 9;
        assertEquals(expected, rs);
    }


    @Test
    public void testSub() {
        int rs = cal.sub(4,5);
        int expected = -1;
        assertEquals(expected, rs);
    }

    @Test
    public void testMul() {
        int rs = cal.mul(4,5);
        int expected = 20;
        assertEquals(expected, rs);
    }

    @Test
    public void testDev() {
        int rs = cal.dev(10,5);
        int expected = 2;
        assertEquals(expected, rs);
    }
    
}
