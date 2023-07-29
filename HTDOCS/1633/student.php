<!DOCTYPE html>
<html>

<head>
    <title>Student detail</title> 
    <!-- mã hiển thị phần mở -->
</head>

<body>
    <?php
    //phần này nằm trong thẻ php sẽ là script viết bằng php
    //hay gọi là server side script language
    //các script này sẽ được dịch và chạy bởi web server
    //khai báo một mảng danh sách sinh viên
    $stdlist = array(array(1, "Nguyen Van An", 5.5),
                     array(2, "Tran Thi Bich", 9.0),
                     array(3, "Mai Thu Hoan", 8.5)
    );
    //kiểm tra id có được gửi lên không
    if (isset($_GET['id']) && $_GET['id'] != "") {    //lấy id được gửi lên bởi client
        $id = $_GET['id'];
        //kiểm tra id có nằm trong khoảng 1-3 hay không?
        if ($id >= 1 && $id <= 3) {
    ?>
            <h1 style="color:blue;">Student detail</h1>
            <p>Id: <?= $stdlist[$id - 1][0] ?></p>
            <p>Name: <?= $stdlist[$id - 1][1] ?></p>
            <p>Mark: <?= $stdlist[$id - 1][2] ?></p>
    <?php
        } else {
            echo "<h1>Student not found</h1>";  
        }
    } else {
        echo "<h1>ID not found</h1>";
    }
    ?>
</body>

</html>