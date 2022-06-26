using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services;

public class MemberServices : IMemberServices
{
    public void CreateMember(Member member)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public void DeleteMember(int memberId)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public IEnumerable<Member> FilterMemberByCity(string City)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public IEnumerable<Member> FilterMemberByCountry(string Country)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public Member Login(string email, string password)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public Member SearchMemberById(int memberId)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public IEnumerable<Member> SearchMemberByName(string name)
    {
        // CODE HERE
        throw new NotImplementedException();
    }

    public void UpdateMember(Member member)
    {
        // CODE HERE
        throw new NotImplementedException();
    }
}
