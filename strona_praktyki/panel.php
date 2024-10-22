<?php
session_start();

if(isset($_SESSION['logon']) && $_SESSION['logon'] == True){
  echo '<h1>Hello, '.$_SESSION['login'].'</h1><br/><a href="logout.php">Wyloguj siê</a>';
}
else{
  $_SESSION['error'] = "Proszê siê zalogowaæ!";
  header('Location: index.php');
  exit();
}
?>
