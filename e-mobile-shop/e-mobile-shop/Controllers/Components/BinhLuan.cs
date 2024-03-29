﻿using e_mobile_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_mobile_shop.Controllers.Components
{
    public class BinhLuanViewComponent:ViewComponent
    {
        private readonly ClientDbContext context;
        public BinhLuanViewComponent(ClientDbContext _context)
        {
            context = _context;
        }
        public async Task<IViewComponentResult> InvokeAsync(string Id)
        {
            var result = context.BinhLuan.Where(x => x.MaSp == Id && x.Status!=0).ToListAsync();
            return View(await result);  
        }
    }
}
