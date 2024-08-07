﻿using System.Net.Http.Json;
using TodoList.Models;

namespace TodoListBlazorWasm.Services
{
    public interface IProceduresService
    {
        Task<List<UserSP>> GetDoctors();
        Task<List<UserSP>> GetReceptionist();
        Task<List<UserSP>> GetCashier();
        Task<List<UserSP>> GetPharmacist();
        Task<List<CountDoctorModel>> NumberOfDoctors();
    }
    public class ProceduresService : IProceduresService
    {
        private readonly HttpClient _httpClient;
        public ProceduresService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserSP>> GetCashier()
        {
            return await _httpClient.GetFromJsonAsync<List<UserSP>>("api/Procedures/GetCashier");
        }

        public async Task<List<UserSP>> GetDoctors()
        {
            return await _httpClient.GetFromJsonAsync<List<UserSP>>("api/Procedures/GetDoctors");
        }

        public async Task<List<UserSP>> GetPharmacist()
        {
            return await _httpClient.GetFromJsonAsync<List<UserSP>>("api/Procedures/GetPharmacist");
        }

        public async Task<List<UserSP>> GetReceptionist()
        {
            return await _httpClient.GetFromJsonAsync<List<UserSP>>("api/Procedures/GetReceptionist");
        }

        public async Task<List<CountDoctorModel>> NumberOfDoctors()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<CountDoctorModel>>("api/Procedures/CountDoctor");
                //if (response.TryGetValue("numberDoctor", out int numberOfDoctors))
                //{
                //    return numberOfDoctors;
                //}
                //else
                //{
                //    return -1; 
                //}
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
