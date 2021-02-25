﻿using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Swellow.Blazor.Services;
using Swellow.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swellow.Blazor.Pages.Media
{
    public partial class Home
    {
        [Inject]
        public IServer Server { get; set; }

        private IEnumerable<LibraryPreview> LibraryPreviews { get; set; } = new List<LibraryPreview>();

        protected override async Task OnInitializedAsync()
        {
            LibraryPreviews = await Server.GetLibraryPreviewsAsync();
            await base.OnInitializedAsync();
        }
    }
}
