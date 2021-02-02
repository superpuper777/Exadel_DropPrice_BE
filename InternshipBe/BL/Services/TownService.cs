﻿using AutoMapper;
using BL.DTO;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
    public class TownService : ITownService
    {
        private readonly ITownRepository _townRepository;
        private readonly IMapper _mapper;

        public TownService(ITownRepository repository, IMapper mapper)
        {
            _townRepository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TownDTO>> GetTownsAsync()
        {
            return _mapper.Map<TownDTO[]>(await _townRepository.GetAllAsync());
        }
    }
}