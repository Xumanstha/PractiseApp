using System;

namespace PractiseApp.Database;

public class CityRepository
{

private static List <string> Cities= new List<string>(){
    "Toronto",
    "Montreal",
    "Ottawa",
    "Calgary",
    "Halifax"
};
public static List<string> GetCity()=>Cities;

}
