<!DOCTYPE html>
<html>
<body>
<h2>Student Result</h2>
<form method="post">
Enter Marks (comma separated):
<input type="text" name="marks"
value="<?php echo isset($_POST['marks']) ? htmlspecialchars($_POST['marks']) : ''; ?>"
required>
<input type="submit" name="submit" value="Calculate">
</form>
<?php
if(isset($_POST['submit']))
{
$marks = explode(",", $_POST['marks']);
$distinction = 0;
$fail = 0;
foreach($marks as $mark)
{
$mark = (int) trim($mark);
if($mark >= 75)
{
$distinction++;
}
else if($mark < 35)
{
$fail++;
}
}
echo "<h3>Distinction Students: $distinction</h3>";
echo "<h3>Failed Students: $fail</h3>";
}
?>
</body>
</html>