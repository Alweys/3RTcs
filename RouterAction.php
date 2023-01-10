<html>
    <body>
        <?php
            require('routeros_api.class.php');

            $API = new RouterosAPI();
            
            $API->debug = true;
            
            if ($API->connect('192.168.56.114', 'admin', 'admin')) {
            
               $API->comm("/ip/firewall/address-list/add",array(
                "address" =>"192.168.1.2",
                "list"    =>"blokiraj",
                "timeout" =>"08:00:00",
                ));

               $API->disconnect();
            
            }

            $correct = "paradajz";

            $ki = $_GET['ime'];
            $loz = $_GET['lozinka'];

            $mysqli = mysqli_connect("localhost", "root", "", "prijavatest");

            $br = 0;

            if($correct == $loz)
                $br = 1;
            else
                $br = 0;
                                 
        if(!mysqli_connect_errno()) {
                                                                                                  
             $sql = "INSERT INTO zapisi(IP, proslo) values ('192.168.0.0', $br)";
             print($sql);
             $results = mysqli_query($mysqli, $sql);
        } else {
            print(" Greška kod spajanja na bazu! " . mysqli_connect_error());
        }                                                 

        ?>
    </body>
</html>