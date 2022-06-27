using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Services;

public class MemberServices : IMemberServices
{
    MemberRepository memberRepository = new MemberRepository();

    private bool checkAdminLogin(string email, string password)
    {
        bool checkAdminLogin = false;

        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", true, true)
            .Build();

        string adminEmail = config["DefaultAccounts:Email"];
        string adminPassword = config["DefaultAccounts:Password"];
        checkAdminLogin = (email == adminEmail) && (password == adminPassword);

        return checkAdminLogin;
    }

    public void CreateMember(Member member)
    {
        // CODE HERE
        memberRepository.CreateMember(member);
    }

    public void DeleteMember(int memberId)
    {
        // CODE HERE
        memberRepository.DeleteMember(memberId);
    }

    public IEnumerable<Member> FilterMemberByCity(string City)
    {
        // CODE HERE
        IEnumerable<Member> list = memberRepository.GetMemberList();
        IEnumerable<Member> result = from member in list
                                     where member.City.Contains(City)
                                     select member;
        return result;
    }

    public IEnumerable<Member> FilterMemberByCountry(string Country)
    {
        // CODE HERE
        IEnumerable<Member> list = memberRepository.GetMemberList();
        IEnumerable<Member> result = from member in list
                                     where member.Country.Contains(Country)
                                     select member;
        return result;
    }

    public Member Login(string email, string password)
    {
        // CODE HERE
        Member loginMember = null;
        if (checkAdminLogin(email, password) == false)
        {
            try
            {
                IEnumerable<Member> list = memberRepository.GetMemberList();
                loginMember = (from member in list
                               where (member.Email == email)
                               && (member.Password == password)
                               select member).First();
            } 
            catch (Exception ex)
            {
                if (ex.Message.Contains("no elements"))
                {
                    throw new Exception("Incorrect Username or Password!");
                }
            }
            
        }
        else
        {
            loginMember = new Member
            {
                MemberID = 0,
                MemberName = "Admin",
                Email = email,
                Password = password,
                City = string.Empty,
                Country = string.Empty,
            };
        }
        return loginMember;
    }

    public Member SearchMemberById(int memberId)
    {
        // CODE HERE
        return memberRepository.GetMember(memberId);
    }

    public IEnumerable<Member> SearchMemberByName(string name)
    {
        // CODE HERE
        IEnumerable<Member> list = memberRepository.GetMemberList();
        IEnumerable<Member> result = from member in list
                             where member.MemberName.Contains(name)
                             select member;
        return result;
    }

    public void UpdateMember(Member member)
    {
        // CODE HERE
        memberRepository.UpdateMember(member);
    }

    public IEnumerable<Member> GetMemberList()
    {
        return memberRepository.GetMemberList();
    }
}
