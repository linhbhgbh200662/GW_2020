package Asm;

import java.util.ArrayList;
import java.util.List;
import javax.swing.ComboBoxModel;
import javax.swing.event.ListDataListener;

public class EmployeeModel implements ComboBoxModel<String> {

    private List<String> gender;
    private Object seleObject;

    public EmployeeModel() {
        gender = new ArrayList<>();
        gender.add("Male");
        gender.add("Female");
    }
 @Override
    public void setSelectedItem(Object anItem) {
        seleObject = anItem;
    }

    @Override
    public Object getSelectedItem() {
        return seleObject;
    }

    @Override
    public int getSize() {
        return gender.size();
    }

    @Override
    public String getElementAt(int index) {
        return gender.get(index);
    }

    @Override
    public void addListDataListener(ListDataListener l) {
    }

    @Override
    public void removeListDataListener(ListDataListener l) {
    }
}
