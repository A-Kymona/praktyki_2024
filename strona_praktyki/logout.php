<?php
session_start();

if(isset($_SESSION['logon']) && $_SESSION['logon'] == True){
  unset($_SESSION['logon']);
  unset($_SESSION['login']);
  $_SESSION['error'] = "Pomy�lnie wylogowano!";
  header('Location: index.php');
  exit();
}
else{
  $_SESSION['error'] = "Prosz� si� zalogowa�!";
  header('Location: index.php');
  exit();
}

?>
