﻿using HotelListing.API.Data;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
