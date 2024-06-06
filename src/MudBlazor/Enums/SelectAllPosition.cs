// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace MudBlazor
{
#pragma warning disable CS1591
    public enum SelectAllPosition
    {
        [Description("Upper line")]
        BeforeSearchBox,
        [Description("Start of the searchbox in the same line")]
        NextToSearchBox,
        [Description("Below line")]
        AfterSearchBox
    }
}
