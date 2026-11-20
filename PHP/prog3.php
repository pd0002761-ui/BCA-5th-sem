<!DOCTYPE html>
<html>
<body>
<h2>Scout Tent Assignment</h2>
<form method="post">
Enter Scout Age:
<input type="number" name="age"
value="<?php echo isset($_POST['age']) ? $_POST['age'] : ''; ?>" required>
<input type="submit" name="submit" value="Assign Tent">
</form>
<?php
if(isset($_POST['submit']))
{
$age = $_POST['age'];
if($age >= 5 && $age <= 10)
{
echo "<h3>Assigned to Tent 1 (Junior Scouts)</h3>";
}
else if($age >= 11 && $age <= 15)
{
echo "<h3>Assigned to Tent 2 (Senior Scouts)</h3>";
}
else if($age >= 16 && $age <= 20)
{
echo "<h3>Assigned to Tent 3 (Adult Scouts)</h3>";
}
else
{
echo "<h3>No Tent Assigned</h3>";
}
}
?>
</body>
</html>