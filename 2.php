<?php
error_reporting("E_ALL");
ini_set('max_execution_time', 300); //300 seconds = 5 minutes


include('src/AbstractGeocoder.php');
include('src/Geocoder.php');

// use OpenCage\Geocoder;


//$v = explode("%",$_GET["q"]);

$query = $_GET["q"];

$geocoder = new OpenCage\Geocoder\Geocoder("5ab628e0cc774e5d9d4a812694c5baa6");
$result = $geocoder->geocode($query);
//print_r($result);


$lat = $result["results"][0]["geometry"]["lat"];
$long = $result["results"][0]["geometry"]["lng"];

$asd = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=".$lat.",".$long."&radius=1500&type=business&keyword=".$values[0]."&key=AIzaSyASILuQcIB0BGRmX93InyFrIkXjXq_quk0";

$cva = file_get_contents($asd);


$cont = file_get_contents($cva);
$obj = json_decode($cont, true);

$arr = $obj["results"];

	for($i=0; $i<count($arr); $i++){

if(!in_array($arr[$i]["name"],$r)){
array_push($r,$arr[$i]["name"]);
}

}





for($i=0; $i<count($r); $i++){
	echo $r[$i]."%";
}



?>