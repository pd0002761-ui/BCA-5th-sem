<!DOCTYPE html>
<html>
<body>
<h2>Factorial of a Number</h2>
<form method="post">
Enter a Number:
<input type="number" name="num" min="0"
value="<?php echo isset($_POST['num']) ? $_POST['num'] : ''; ?>" required>
<input type="submit" name="submit" value="Calculate">
</form>
<?php
if(isset($_POST['submit']))
{
$num = $_POST['num'];
$fact = 1;
for($i = 1; $i <= $num; $i++)
{
$fact = $fact * $i;
}
echo "<h3>Factorial of $num is $fact</h3>";
}
?>
</body>
</html>