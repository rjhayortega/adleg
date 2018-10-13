<?php

$servername = "remotemysql.com";
$username = "9JFEyxle8K";
$password = "rLx6FxmOoH";
$dbname = "9JFEyxle8K";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT frm, kword FROM requests order by id DESC LIMIT 1";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
       echo $row["frm"].",".$row["kword"];
        
    }


} else {
    echo "0 results";
}
$conn->close();


$a = shell_exec("mono test.exe");

echo $a;


?> 