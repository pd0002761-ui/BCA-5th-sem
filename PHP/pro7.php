<!DOCTYPE html>
<html>
<body>
<h2>GCF and LCM Calculator</h2>
<form method="post">
Enter First Number:
<input type="number" name="num1"
value="<?php echo $_POST['num1'] ?? ''; ?>" min="1" required>
<br><br>
Enter Second Number:
<input type="number" name="num2"
value="<?php echo $_POST['num2'] ?? ''; ?>" min="1" required>
<br><br>
<input type="submit" name="submit" value="Calculate">
</form>
<?php
if(isset($_POST['submit']))
{
$a = (int)$_POST['num1'];
$b = (int)$_POST['num2'];
$x = $a;
$y = $b;
while($y != 0)
{
$temp = $y;
$y = $x % $y;
$x = $temp;
}
$gcf = $x;
$lcm = ($a * $b) / $gcf;
echo "<h3>GCF = $gcf</h3>";
echo "<h3>LCM = $lcm</h3>";
}
?>
</body>
</html>