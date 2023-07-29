<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http--equiv="X-UA-Compatible" content="IE-edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>First Web by Php</title>
</head>
<body>
    <h1> Xử lý Query String</h1>
    <script>
        document.write("Welcome to first php page"<br>);
    </script>
    <?php
    for($i=0; $i<10; $i++)
        if($i%2)
            echo "<h1 style='color: red;'>Welcome to first php page </h1>";
        else
            echo "<h1 style='color: blue;'>Welcome to first php page </h1>";
    ?>

  <ul>
    <?php
    for($i=0; $i<10; $i++)
    {
    ?>
        <li>Welcome to first php page </li>
    <?php
    }
    ?>
    <?php
    $stdnames = array("Nam", "Hòa", "Hiền", "Tuấn", "Lâm");
    for($i=0; $i<count($stdnames); $i++)
    {
        if($i%2)
        {
    ?>
        <li style="color: red;"><?php(viết tắt <?=$stdnames) echo $stdnames[$i]?></li>
    <?php
        }
        else
        {
    ?>
        <li style="color: blue;"><?php echo $stdnames[$i]?></li>
    <?php
        }
    }
    ?>
  </ul>

  <div class="row header">
  <?php
  include_once("first_template_header.php");
  ?>



  bài khác:
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


