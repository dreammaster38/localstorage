﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LocalStorage
{
    /// <summary>
    /// Provides options to configure LocalStorage to behave just like you want it.
    /// </summary>
    public class LocalStorageConfiguration : ILocalStorageConfiguration
    {
        /// <summary>
        /// Indicates if LocalStorage should automatically persist the latest state to disk, on dispose (defaults to true).
        /// </summary>
        /// <remarks>
        /// Disabling this requires a manual call to Persist() in order to save changes to disk.
        /// </remarks>
        public bool AutoSave { get; set; } = true;

        /// <summary>
        /// Filename for the persisted state on disk (defaults to ".localstorage").
        /// </summary>
        public string Filename { get; set; } = ".localstorage";
    }
}
