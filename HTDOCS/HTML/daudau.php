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
    //Xử lý query string
    //Muốn lấy dữ liệu gửi lên băngf method get thì ta dùng biến $_GET
    $id = $_GET['id'];
    echo " Du lieu viua nhan duoc la: " . $id;
    ?>




    <div class="row header">
        <?php
        include_once("first_template_header.php");
        ?>
    </div>
    <!-- end header -->
    <div class="row">
    <!-- left -->
    <div classs="left col-lg-3">
        <?php
        include_once("first_template_left.php");
        ?>
    </div>
    <!-- end left -->
    <div class="right col-lg-9">
        <div class="row">
            <!-- main -->
            <div class="col-lg-8">
                <?php
                include_once("first_template_main.php");
                ?>
            </div>

</body>
</html>

<form action="" method="post">
    <div class="form-group">
        <label for="usn">User name:</label>
        <input type="text" class="form-control" id="email" name="usn">
    </div>
    <div class="form-group">
        <label for="pwd">Password:</label>
        <input typpe="password" class="form-control" id="pwd" name="pwd">
    </div>
    <div class


