package Demo;

import java.util.ArrayList;
import java.util.List;
import javax.swing.ComboBoxModel;
import javax.swing.event.ListDataListener;

public class MyModel implements ComboBoxModel<String> {

    private List<String> kindofroom;
    private Object seleObject;

    public MyModel() {
        kindofroom = new ArrayList<>();
        kindofroom.add("Affordable");
        kindofroom.add("Vip");
        kindofroom.add("President");

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
        return kindofroom.size();
    }

    @Override
    public String getElementAt(int index) {
        return kindofroom.get(index);
    }

    @Override
    public void addListDataListener(ListDataListener l) {
    }

    @Override
    public void removeListDataListener(ListDataListener l) {
    }
}
