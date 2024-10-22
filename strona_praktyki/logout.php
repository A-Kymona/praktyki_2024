<?php
session_start();

if(isset($_SESSION['logon']) && $_SESSION['logon'] == True){
  unset($_SESSION['logon']);
  unset($_SESSION['login']);
  $_SESSION['error'] = "Pomyœlnie wylogowano!";
  header('Location: index.php');
  exit();
}
else{
  $_SESSION['error'] = "Proszê siê zalogowaæ!";
  header('Location: index.php');
  exit();
}

?>
