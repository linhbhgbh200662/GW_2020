<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http--equiv="X-UA-Compatible" content="IE-edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>First Web by Php</title>
</head>
<body>
    <script>
        document.write("Welcome to first php page<br>");
    </script>
    <a href="firstphp.php?id=gch1002">link to profile</a>
    <?php
    include_once("hello.php");
    //Xử lý query string
    //Muốn lấy dữ liệu gửi lên băngf method get thì ta dùng biến $_GET
    //giả xử load đc csdl trong acount 
    $accs = query("SELECT * FROM account");
    if(isset($_POST['un']) && isset($_POST['pw'])){
        $un = $_POST['un'];
        $pw = $_POST['pw'];
        $found = false;
        foreach ($accs as $acc)
        {
            if($acc[1] == $un && $acc[2] == $pw)
            {
                $found = true;
                break;
            }
        }
            if($found) {
                echo "<script>alert('Success')</script>";
            }
            else{
                echo "<script>alert('Falied')</script>";
            }
            
        
         //for($i=0; $i<count($acc); $i++){
           // if($un==$acc[$i][0] && $pw==$acc[$i][1])
           // header("Location:admin.php");
           //} 
         //if($i>=count($acc)) 
          //echo"Incorrect username or password"; 
    }
   // if(isset($_GET['id'])){
    //    $id = $_GET['id'];
    //    echo " Du lieu vua nhan duoc la: " . $id;
    //}
    //Muốn lấy dữ liệu bằng method post ta dung biến $_POST
    ?>
    <form action="" method="post">
    user: <input type="text" name="un"> <br>
    pass: <input type="text" name="pw"> <br>
    <input type="submit" value="login">
    </form>
</body>
</html>   

// menu trong asm 

<?php
if(isset($_GET['catid']))
    $sql = "Select * from product where catid= '" . $_GET['catid'] . "'";
elseif(isset($_GET['keyword']))
    $sql = "Select * from product where productname like '%" . $_GET['keyword'] . "%";
else 
    $sql = "Select * from product";
$rows = query($sql);
?>
<div class="row">
    <?php
    for($i=0; $i<count($rows); $i++);
    {
        ?>
        <div class="col-lg-4">
            <div class="item">
                <div>
                    <a href="">
                        <img src="<?=$rows[$i][2]?>" alt="">
                    </a>
                </div>
                <div><?=$rows[$i][1]?></div>
                <div><?=$rows[$i][3]?></div>
            </div>
        </div>
        <?php
    }
    ?>
</div>


<?php
$sql = "Select * from category ";
$rows = query($swl);
?>{
<nav class="navbar bg-light">
    <ul class="navbar-nav">
        <?php
        for($i=0; $i<count($rows); $i++)
        {
            ?>
            <li class="nav-item"><a href="hello.php>catid=<?=$rows[$i][0]?>" class> 
            <?php
        }
        ?>
    </ul>
</nav>
    
