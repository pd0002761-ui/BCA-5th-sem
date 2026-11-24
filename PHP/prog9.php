<?php 
$source = fopen("source.txt", "r"); 
$destination = fopen("destination.txt", "w"); 
if($source && $destination) 
{  
while(!feof($source)) 
{  
$data = fgetc($source); 
if($data !== false) 
{ 
fwrite($destination, $data);
}
} 
echo "File copied successfully."; 
fclose($source); 
fclose($destination);
} 
else 
{   
echo "Unable to open file."; 
}
?>