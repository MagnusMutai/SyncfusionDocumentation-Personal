﻿using Syncfusion.Blazor;
namespace SyncfusionDocumentation_Personal.Culture;
public class SyncfusionLocalizer : ISyncfusionStringLocalizer
{
    public string? GetText(string key)
    {
        return this.ResourceManager.GetString(key);
    }

    public System.Resources.ResourceManager ResourceManager
    {
        get
        {
            // Replace the ApplicationNamespace with your application name.
            return Resources.SfResources.ResourceManager;

            //For .Net Maui Blazor App
            // Replace the ApplicationNamespace with your application name.
            //return ApplicationNamespace.LocalizationResources.SfResources.ResourceManager;
        }
    }
}
