<?php 
class Student 
{  
 function __construct() 
{ 
 echo "Constructor is called.<br>";
} 
function display() 
{  
 echo "Welcome to PHP Programming.<br>";
} 
function __destruct() 
{ 
 echo "Destructor is called.";
}
} 
$obj = new Student (); 
$obj->display(); 
?> 