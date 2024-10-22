<?php
session_start();

if(isset($_SESSION['logon']) && $_SESSION['logon'] == True){
  header('Location: index.php');
  exit();
}

?>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Panel Logowania</title>
</head>
<body>
  <form method="post" action="login.php">
    <input type="text" name="login" placeholder="Login" /><br/>
    <input type="password" name="pass" placeholder="Has³o" /><br/>
    <input type="submit" value="Zaloguj siê" />
  </form>

  <?php
    if(isset($_SESSION['error'])){
      echo '<span style="color: red; font-weight: bold;">'.$_SESSION['error'].'</span>';
      unset($_SESSION['error']);
    }
  ?>

</body>
</html>
