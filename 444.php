<?php 
ini_set('max_execution_time', 300); 

/*
 $myfile = fopen("f.txt", "r") or die("Unable to open file!"); 
$aa = fread($myfile,filesize("f.txt")); fclose($myfile); */ 


$txt = "\\n,null,null,null,null,\\"; 

$start = false; 
$built = ""; 
$count = 0; 



for($x=3; $x<6; $x++){ 

$thestring = "plumbers%20fargo%20nd";



$aa = shell_exec("mono test.exe ".$thestring." ".$x);


for($i=0; $i<strlen($aa); $i++){ 
   

if($aa{$i}=="\\" && $aa{$i+1}=="n" && $aa{$i+2}=="," &&  $aa{$i+(strlen($txt)-1)}=="\\"){
	    $start = true;
	  
		$i += strlen($txt)+1;
		
	}
	
	
	if($start){
		
		try{

		$built .= $aa{$i};
		
	
		if($aa{$i}=="," ){
			
			if(strpos($built,"\\")!==False){
		
			}
			else{
				if(strlen($built)>2){
				$built = str_replace(",","",$built);
				echo $built."</br></br>";
				}
			
			
			}
			$built = "";
			$start = false;
		
		}
	
	
	
	}


catch(Exception $e) {

}
	
	}
}
	
	
	
	}

?>
