<!DOCTYPE html>
<html>
<head>
<title>GET Method</title>
</head>
<body>
<h2>Enter Username</h2>
<form method="GET" action="">
Username:
<input type="text" name="username"
value="<?php echo htmlspecialchars($_GET['username'] ?? ''); ?>"
required>
<input type="submit" value="Submit">
</form>
<?php
if (isset($_GET['username'])) {
echo "<h3>Welcome, " .
htmlspecialchars($_GET['username']) . "</h3>";
}
?>
</body>
</html>
