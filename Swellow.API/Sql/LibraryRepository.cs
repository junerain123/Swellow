﻿using Microsoft.EntityFrameworkCore;
using Swellow.API.Sql.Init;
using Swellow.Shared.Dto.Metadata.Media;
using Swellow.Shared.Dto.View;
using Swellow.Shared.SqlModel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swellow.API.Sql
{
    public class LibraryRepository
    {
        private readonly SwellowDbContext _context;

        public LibraryRepository(SwellowDbContext swellowDbContext)
        {
            _context = swellowDbContext;
        }


        // 1 获取所有LibraryPreviews，主要用于主页
        public async Task<IEnumerable<LibraryPreview>> GetAllLibraryPreviewsAsync()
        {
            IEnumerable<LibraryPreview> libraryPreviews =  await _context.Librarys
                .Select(Library=>new LibraryPreview
                { 
                    Id = Library.Id, 
                    Name = Library.Name, 
                    Fanart = Library.Fanart 
                })
                .ToListAsync();

            return libraryPreviews;
        }


        // 2 依据Id获取某个Library的Name
        public async Task<string> GetLibraryNameByIdAsync(int id)
        {
            return await _context.Librarys.Where(Library => Library.Id == id)
                                        .Select(Library => Library.Name)
                                        .FirstOrDefaultAsync();
        }


        // 3 得到Works，通过LibraryId
        public async Task<IEnumerable<WorkPreview>> GetWorkPreviewsByLibraryIdAsync(int id)
        {
            var workPreviews = await _context.Works.Where(Work => Work.LibraryId == id)
                                      .Select(Work => new WorkPreview
                                      {
                                          Id = Work.Id,
                                          Name = Work.Name,
                                          Year = Work.Year,
                                          Type = Work.Type,
                                          Poster = Work.Poster,
                                      })
                                      .ToListAsync();

            return workPreviews;
        }


    }
}
