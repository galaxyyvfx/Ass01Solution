﻿namespace DataAccess.Entities;

public class Member
{
    public int MemberID { get; set; }
    public string MemberName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}