<?php
    $username = $_GET['username'];
    $password = $_GET['password'];
    $mysqli = mysqli_connect("localhost", "root", "", "idstest");    // spajanje na server i bazu


	if(!mysqli_connect_errno()) 
	{         // provjera da li je bila greska

		$sql = "SELECT * FROM users";
		//print($sql);
		$result = mysqli_query($mysqli, $sql);     // izvršavanje upita

		if($result==True) 
		{
			if($mysqli->affected_rows==0) 
			{
				echo "Nema usera."; 
			} 
			else 
			{
				while($row = mysqli_fetch_assoc($result)) 
				{ // dohvat svakog retka iz $result
					//print($row['username']);               // ispis svakog retka
					$success=0;
					$ip = "";
					if($row['password'] == $password)
					{
						print("Dobrodošao!</br>");
						$success=1;
					}
					else
					{
						print("Kriva lozinka!</br>");
					}
					if (!empty($_SERVER['HTTP_CLIENT_IP'])) {
						$ip = $_SERVER['HTTP_CLIENT_IP'];
					} elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR'])) {
						$ip = $_SERVER['HTTP_X_FORWARDED_FOR'];
					} else {
						$ip = $_SERVER['REMOTE_ADDR'];
					}
					//print($ip);
					$sql = "INSERT INTO logins(ip, time, success) values ('$ip', '" . date('Y-m-d H:i:s', time()) . "', $success)";
					//print($sql);
					$results = mysqli_query($mysqli, $sql);
				}
				mysqli_free_result($result);  // oslobađanje memorije

				$sql = "SELECT * FROM logins";
				
			}

		} 
		else 
		{
			print(" Upit je neuspješno izvršen! ");
		}	

	} 
    else 
	{
		print(" Greška kod spajanja na bazu! " . mysqli_connect_error());
	}


?>