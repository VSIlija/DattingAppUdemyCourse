using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUsername(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Username == username);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            //_context.Entry(user).State = EntityState.Modified;
        }

        public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
            return await _context.Users
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<MemberDto> GetMemberAsync(string username)
        {
            return await _context.Users
                .Where(x => x.Username == username)
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<MemberDto> UpdateUser(MemberDto dto)
        {                                                                                                                                                                                                                                                                                                                                                  
            var userForUpdate = await _context.Users.Where(x => x.Id == 1).FirstOrDefaultAsync();
            if (userForUpdate == null)
            {
                //handle no found for user
            }
            AppUser user = _mapper.Map<AppUser>(dto);

            userForUpdate.Id = user.Id;
            userForUpdate.FirstName = user.FirstName;
            userForUpdate.LastName = user.LastName;
            userForUpdate.Username = user.Username;
            userForUpdate.Email = user.Email;
            userForUpdate.DateOfBirth = user.DateOfBirth;
            userForUpdate.KnownAs = user.KnownAs;
            userForUpdate.Created = user.Created;
            userForUpdate.LastActive = user.LastActive;
            userForUpdate.LookingFor = user.LookingFor;
            userForUpdate.Gender = user.Gender;
            userForUpdate.Introduction = user.Introduction;
            userForUpdate.Interests = user.Interests;
            userForUpdate.City = user.City;
            userForUpdate.Country = user.Country;
            userForUpdate.Photos = user.Photos;
            userForUpdate.Job = user.Job;
            userForUpdate.Company = user.Company;
            userForUpdate.Education = user.Education;
            userForUpdate.Height = user.Height;
            userForUpdate.Children = user.Children;
            userForUpdate.Drinking = user.Drinking;
            userForUpdate.Relationship = user.Relationship;
            userForUpdate.Religion = user.Religion;
            userForUpdate.Sexuality = user.Sexuality;
            userForUpdate.Smoking = user.Smoking;
            userForUpdate.StarSign = user.StarSign;
            userForUpdate.Relationship = user.Relationship;
            userForUpdate.Personality = user.Personality;
            userForUpdate.WhyYouAreHere = user.WhyYouAreHere;
            userForUpdate.School = user.School;
            userForUpdate.InterestedInGenders = user.InterestedInGenders;

            await _context.SaveChangesAsync();

            return _mapper.Map<MemberDto>(userForUpdate);

        }

        public void Delete()
        {
            _context.Database.EnsureDeletedAsync();
        }
    }
}
