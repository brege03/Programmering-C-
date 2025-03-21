var preHistoricFish = "Cock";

var result = preHistoricFish switch
{
    "Heliobatis" => "Heliobatis",
    "Cockerelitte" => "Cockerelitte",
    _=> "No match"
};

Console.WriteLine("This is a " + result);

