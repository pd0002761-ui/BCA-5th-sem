<?php
// Database connection settings
$host = "localhost";
$username = "root";
$password = "";
$database = "college";

$message = "";

// Connect to MySQL
$conn = new mysqli(
    $host,
    $username,
    $password,
    $database
);

// Check connection
if ($conn->connect_error) {
    die("Database connection failed: " .
        $conn->connect_error);
}

// Set character encoding
$conn->set_charset("utf8mb4");

// Process the form when Submit is clicked
if ($_SERVER["REQUEST_METHOD"] === "POST") {

    // Read values entered in the form
    $name = trim($_POST["name"] ?? "");
    $email = trim($_POST["email"] ?? "");
    $course = trim($_POST["course"] ?? "");

    // Validate the values
    if ($name === "" || $email === "" || $course === "") {
        $message = "Please fill in all the fields.";
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $message = "Please enter a valid email address.";
    } else {
        // Insert values into the database safely
        $stmt = $conn->prepare(
            "INSERT INTO students(name, email, course)
             VALUES (?, ?, ?)"
        );

        $stmt->bind_param("sss", $name, $email, $course);

        if ($stmt->execute()) {
            $message = "Student details saved successfully.";
        } else {
            $message = "Unable to save student details.";
        }

        $stmt->close();
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Student Registration</title>
</head>
<body>

    <h2>Student Registration Form</h2>

    <form method="POST" action="">
        <label for="name">Student Name:</label>
        <input type="text" id="name" name="name" required>
        <br><br>

        <label for="email">Email:</label>
        <input type="email" id="email" name="email" required>
        <br><br>

        <label for="course">Course:</label>
        <input type="text" id="course" name="course" required>
        <br><br>

        <button type="submit">Submit</button>
    </form>

    <p>
        <?php echo htmlspecialchars($message, ENT_QUOTES, "UTF-8"); ?>
    </p>

    <hr>

    <h2>Registered Students</h2>

    <?php
    // Read all saved records from MySQL
    $sql = "SELECT id, name, email, course
            FROM students
            ORDER BY id DESC";

    $result = $conn->query($sql);

    if ($result && $result->num_rows > 0) {
        echo "<table border='1' cellpadding='8'>";
        echo "<tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Course</th>
              </tr>";

        while ($row = $result->fetch_assoc()) {
            echo "<tr>";
            echo "<td>" . (int)$row["id"] . "</td>";
            echo "<td>" . htmlspecialchars($row["name"], ENT_QUOTES, "UTF-8") . "</td>";
            echo "<td>" . htmlspecialchars($row["email"], ENT_QUOTES, "UTF-8") . "</td>";
            echo "<td>" . htmlspecialchars($row["course"], ENT_QUOTES, "UTF-8") . "</td>";
            echo "</tr>";
        }

        echo "</table>";
    } else {
        echo "No student records found.";
    }

    $conn->close();
    ?>

</body>
</html>