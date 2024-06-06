// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace MudBlazor
{
#pragma warning disable CS1591
    public enum ValuePresenter
    {
        [Description("none")]
        None,
        [Description("text")]
        Text,
        [Description("chip")]
        Chip,
        [Description("itemcontent")]
        ItemContent,
    }
}
