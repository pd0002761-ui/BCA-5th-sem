<?php 
$filename = "myfile.txt"; 
 
// Create and open the file 
$file = fopen($filename, "w"); 
 
if($file) 
{ 
    $text = "Welcome to PHP Programming.\n"; 
    $text .= "This is a file handling program."; 
 
    // Write data into the file    
    fwrite($file, $text); 
 
    echo "File created and data written successfully."; 
 
    // Close the file    
 fclose($file); 
} else {     
echo "Unable to create file."; 
} 
?> 
