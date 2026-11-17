<?php
$conn = new mysqli("localhost", "root", "", "college_records");
if($conn->connect_error)
{
die("Connection Failed");
}
$message = "";
if(isset($_POST['submit']))
{
$name = $_POST['name'];
$email = $_POST['email'];
$course = $_POST['course'];
$stmt = $conn->prepare(
"INSERT INTO students(name, email, course)
VALUES (?, ?, ?)"
);
$stmt->bind_param("sss", $name, $email, $course);
if($stmt->execute())
{
$message = "Record Inserted Successfully!";
}
else
{
$message = "Insertion Failed!";
}
$stmt->close();
}
?>
<!DOCTYPE html>
<html>
<body>
<h2>Insert Student Records</h2>
<form method="POST">
Name:
<input type="text" name="name"
value="<?php echo htmlspecialchars($_POST['name'] ?? ''); ?>" required>
<br><br>
Email:
<input type="email" name="email"
value="<?php echo htmlspecialchars($_POST['email'] ?? ''); ?>" required>
<br><br>
Course:
<input type="text" name="course"
value="<?php echo htmlspecialchars($_POST['course'] ?? ''); ?>" required>
<br><br>
<input type="submit" name="submit" value="Insert">
</form>
<h3><?php echo htmlspecialchars($message); ?></h3>
<h2>Student Records</h2>
<?php
$result = $conn->query("SELECT * FROM students");
if($result->num_rows > 0)
{
echo "<table border='1' cellpadding='8'>";
echo "<tr>
<th>ID</th>
<th>Name</th>
<th>Email</th>
<th>Course</th>
</tr>";
while($row = $result->fetch_assoc())
{
echo "<tr>";
echo "<td>".$row['id']."</td>";
echo "<td>".htmlspecialchars($row['name'])."</td>";
echo "<td>".htmlspecialchars($row['email'])."</td>";
echo "<td>".htmlspecialchars($row['course'])."</td>";
echo "</tr>";
}
echo "</table>";
}else
{
echo "No Records Found.";
}
$conn->close();
?>
</body>
</html>