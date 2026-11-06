<!DOCTYPE html> 
<html> 
<body> 
<h2>Login Authentication System</h2> 
<form method="POST"> 
Username: 
<input type="text" name="username" 
value="<?php echo htmlspecialchars($_POST['username'] ?? ''); ?>" required> 
<br><br> 
Password: 
<input type="password" name="password" 
value="<?php echo htmlspecialchars($_POST['password'] ?? ''); ?>" required> 
<br><br> 
<input type="submit" name="login" value="Login"> 
</form> 
<?php 
if(isset($_POST['login'])) 
{ 
$username = $_POST['username']; 
$password = $_POST['password']; 
if($username == "priya" && $password == "123") 
{ 
echo "<h3>Login Successful! Welcome priya.</h3>"; 
} 
else 
{ 
echo "<h3>Invalid Username or Password!</h3>";
}
}
?> 
</body> 
</html>