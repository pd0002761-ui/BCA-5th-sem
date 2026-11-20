<!DOCTYPE html>
<html>
<body>
<h2>Age Calculator</h2>
<form method="post">
Enter Date of Birth:
<input type="date" name="dob"
value="<?php echo isset($_POST['dob']) ? $_POST['dob'] : ''; ?>" required>
<input type="submit" name="submit" value="Calculate Age">
</form>
<?php
if(isset($_POST['submit']))
{
$dob = new DateTime($_POST['dob']);
$today = new DateTime();
if($dob > $today)
{
echo "<h3>Invalid Date of Birth</h3>";
}
else
{
$age = $dob->diff($today);
echo "<h3>Your Age is " . $age->y . " Years and "
. $age->m . " Months</h3>";
}
}
?>
</body>
</html>
