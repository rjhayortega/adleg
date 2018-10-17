<?php
error_reporting("E_ALL");
ini_set('max_execution_time', 300); //300 seconds = 5 minutes

$r = array();
$s = array();


$qry = str_replace(" ","%20",$_GET["query"]);



$values = explode(" ",$qry);

$app="&location=46.8727758,-97.3683261&radius=50000";


$cont = file_get_contents("https://maps.googleapis.com/maps/api/place/textsearch/json?query=".$qry."&key=AIzaSyASILuQcIB0BGRmX93InyFrIkXjXq_quk0");



$obj = json_decode($cont, true);

$tkn = $obj["next_page_token"];
$count = 0;

$arr = $obj["results"];

for($i=0; $i<count($arr); $i++){

if(!in_array($arr[$i]["name"],$r)){
array_push($r,$arr[$i]["name"]);
array_push($s,$arr[$i]["formatted_address"]);


}
}
;




for($x=0; $x<10; $x++){
$str = "https://maps.googleapis.com/maps/api/place/textsearch/json?query=".$qry."&key=AIzaSyASILuQcIB0BGRmX93InyFrIkXjXq_quk0&pagetoken=".$tkn;

$cont = file_get_contents($str);
$obj = json_decode($cont, true);



$arr = $obj["results"];

for($i=0; $i<count($arr); $i++){

if(!in_array($arr[$i]["name"],$r)){
array_push($r,$arr[$i]["name"]);
array_push($s,$arr[$i]["formatted_address"]);
}

}


if(array_key_exists("next_page_token",$obj)){
$tkn = $obj["next_page_token"];
}
}



include('src/AbstractGeocoder.php');
include('src/Geocoder.php');

// use OpenCage\Geocoder;

/*

for($x=0; $x<count($r); $x++){
	$v = explode("%",$s[$x]);

$query = $v[1];

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

}
*/



for($i=0; $i<count($r); $i++){
	echo $r[$i]."%";
}

echo "*";

for($i=0; $i<count($s); $i++){
	echo $s[$i]."%";
}



?>