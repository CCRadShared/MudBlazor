﻿// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

#nullable enable

namespace MudBlazor
{
    /// <summary>
    /// Represents an option of a select or multi-select. To be used inside MudSelect.
    /// </summary>
    public partial class MudSelectItemGroupExtended<T> : MudBaseSelectItem
    {

        //private IMudSelect _parent;
        internal string ItemId { get; } = "_" + Guid.NewGuid().ToString().Substring(0, 8);

        /// <summary>
        /// A user-defined option that can be selected
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public T? Value { get; set; }

        /// <summary>
        /// A user-defined option that can be selected
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public string? Text { get; set; }

        /// <summary>
        /// A user-defined option that can be selected
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool Nested { get; set; }

        /// <summary>
        /// Sets the group's expanded state on popover opening. Works only if nested is true.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool InitiallyExpanded { get; set; }

        /// <summary>
        /// Sticky header for item group. Works only with nested is false.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool Sticky { get; set; }

        [CascadingParameter]
        internal MudListExtended<T?>? MudListExtended { get; set; }

        /// <summary>
        /// Select items with HideContent==true are only there to register their RenderFragment with the select but
        /// wont render and have no other purpose!
        /// </summary>
        [CascadingParameter(Name = "HideContent")]
        internal bool HideContent { get; set; }

        private void HandleExpandedChanged(bool isExpanded)
        {
            if (isExpanded)
            {
                MudListExtended?.UpdateSelectedStyles();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                //This line is for nested and initially expanded items. Still doesn't work for multiselection
                MudListExtended?.UpdateSelectedStyles(false);
            }
        }

    }
}
