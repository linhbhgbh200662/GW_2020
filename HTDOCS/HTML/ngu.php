<?php
//kết nối cơ sở dữ liệu
$hostname = 'localhost';
$username = 'root';
$password = '';
$dbname = 'storeman';
$port = 3306;
function query($sql)
{
    global $hostname;
    global $username;
    global $password;
    global $dbname;
    global $port;
    $conn = new mysqli($hostname, $username, $password, $dbname, $port );
    if($conn->connect_error)
    {
        //nếu như kết nối không thành công thì dừng chương trình 
        echo "Connection fail<br>";
        //dừng chương trình
        die($conn->connect_error);
    }
    //chạy câu truy vấn lấy kết quả
    $result = $conn->query($sql);
    if(!$result)
    {
        //nếu không có kết quả ($result-null) thì dừng chương trình
        echo"SQL execution fail <br>";
        die($conn->error);
    }
    //lấy all các bản ghi từ kết quả
    $rows = $result->fetch_all();// chuyển dữ liễu result về dạng mảng 
    //$rows = $result->fetch_all(MYSQL_ASSOC);
    return $rows; 
}
?>

<?php
$sql = "Select * from Category ";
$rows = query($sql);
?>

<nav class="navbar bg-light">
    <ul class="navbar-nav">
        <?php
        for($i=0; $i<count($rows); $i++)
        {
        ?>
            <li class="nav-item"><a href="first_template_home.php?catid=<?=$rows[$i][0]?> 
        <?php
        }
        ?>
        </ul>
</nav> 

funciton execsq($sql)  // execsql dùng để thêm, sửa, xóa
{
    global $hostname;
    global $username;
    global $password;
    global $dbname;
    global $port;
    $conn = new mysqli($hostname, $username, $password, $dbname, $port );
    if($conn->connect_error);
    {
        //nếu như kết nối k thành công thì dừng chương trình
        echo "Connection fail<br>";
        //dừng trương trình
        die($conn->connect_error);
    }
}
//chạy câu truy vấn lấy kết quả
$result = $conn-> query($sql)  // query dùng để truy vấn
return $result;
?>

