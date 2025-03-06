using System;
using System.ComponentModel.DataAnnotations;

namespace PractiseApp.Models;

public class Server
{
    [Required]
public string? Name{get;set;}
public int Id{ get;set;}
[Required]
public string? City{get;set;}
public bool IsOnline{get;set;}
public Server()
{
    Random random=new Random();
    int randomNumber=random.Next(0,2);
    IsOnline=randomNumber==0?false:true;
}
}
