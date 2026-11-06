<?php
$conn = new mysqli("localhost", "root", "", "student_registration_db");

if ($conn->connect_error) {
    die("Connection Failed: " . $conn->connect_error);
}

$message = "";

if (isset($_POST['submit'])) {

    $name = trim($_POST['name']);
    $email = trim($_POST['email']);
    $gender = $_POST['gender'] ?? "";
    $course = $_POST['course'];
    $phone = trim($_POST['phone']);

    $stmt = $conn->prepare("INSERT INTO students(name,email,gender,course,phone) VALUES(?,?,?,?,?)");

    $stmt->bind_param("sssss", $name, $email, $gender, $course, $phone);

    $message = $stmt->execute()
        ? "Registration Successful!"
        : "Registration Failed!";

    $stmt->close();
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Student Registration</title>
</head>
<body>

<h2>Student Registration Form</h2>

<form method="POST">

    Name:
    <input type="text" name="name" required>
    <br><br>

    Email:
    <input type="email" name="email" required>
    <br><br>

    Gender:
    <input type="radio" name="gender" value="Male" required> Male
    <input type="radio" name="gender" value="Female"> Female
    <br><br>

    Course:
    <select name="course" required>
        <option value="">Select Course</option>
        <option>BCA</option>
        <option>MCA</option>
        <option>BCom</option>
        <option>BSc</option>
    </select>
    <br><br>

    Phone:
    <input type="text" name="phone" required>
    <br><br>

    <input type="submit" name="submit" value="Register">

</form>

<h3><?php echo htmlspecialchars($message); ?></h3>

<hr>

<h2>Registered Students</h2>

<?php

$result = $conn->query("SELECT * FROM students ORDER BY id DESC");

if ($result->num_rows > 0) {

    echo "<table border='1' cellpadding='8'>
    <tr>
    <th>ID</th>
    <th>Name</th>
    <th>Email</th>
    <th>Gender</th>
    <th>Course</th>
    <th>Phone</th>
    </tr>";

    while ($row = $result->fetch_assoc()) {

        echo "<tr>";

        foreach ($row as $value) {
            echo "<td>" . htmlspecialchars($value) . "</td>";
        }

        echo "</tr>";
    }

    echo "</table>";

} else {

    echo "No Records Found.";

}

$conn->close();

?>

</body>
</html>