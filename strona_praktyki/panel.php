<?php
session_start();

if(isset($_SESSION['logon']) && $_SESSION['logon'] == True){
  echo '<h1>Hello, '.$_SESSION['login'].'</h1><br/><a href="logout.php">Wyloguj si�</a>';
}
else{
  $_SESSION['error'] = "Prosz� si� zalogowa�!";
  header('Location: index.php');
  exit();
}
?>
