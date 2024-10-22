<?php
session_start();

if(isset($_POST['login']) && isset($_POST['pass'])){
  if(strlen($_POST['login']) < 3 || strlen($_POST['pass']) < 3){
    $_SESSION['error'] = "Dane musz¹ mieæ wiêcej ni¿ 3 znaki!";
    header('Location: index.php');
    exit();
  }
  else{
    $login = htmlentities($_POST['login'], ENT_QUOTES, "UTF-8");
    $pass = $_POST['pass'];

    try{
      $connection = new mysqli("localhost", "root", "", "logowanie");

      if($connection->connect_errno != 0){
        throw new Excepetion(mysqli_connect_errno());
      }
      else{
        if($reply = mysqli_query($connection, "SELECT * FROM users WHERE login='$login'")){
          if($reply->num_rows > 0){
            $row = $reply->fetch_assoc();
            if(password_verify($pass, $row['pass'])){
              $_SESSION['logon'] = True;
              $_SESSION['login'] = $row['login'];

              $connection->close();
              header('Location: index.php');
              exit();}

            else{
              $_SESSION['error'] = "Dane s¹ nieprawid³owe!";
              header('Location: logowanie.php');
              exit();}

          }
          else{
             $_SESSION['error'] = "Dane s¹ nieprawid³owe!";
             header('Location: logowanie.php');
             exit();}
        }

        else{
          $_SESSION['error'] = "B³¹d zapytania bazy danych!";
          header('Location: logowanie.php');
          exit();}

      }
    }
    catch(Exception $e){
      $_SESSION['error'] = "B³¹d bazy danych!";
      header('Location: logowanie.php');
      exit();
    }
  }
}
else{
  $_SESSION['error'] = "Proszê wprowadziæ dane!";
  header('Location: logowanie.php');
  exit();
}
?>
