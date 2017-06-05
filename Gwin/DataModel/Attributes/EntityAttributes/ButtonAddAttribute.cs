﻿using System;

namespace GApp.GwinApp.Attributes
{
    /// <summary>
    /// The Add button of Management Interface
    /// </summary>
    public class AddButtonAttribute : BaseAttribute
    {
        /// <summary>
        /// Title of add button
        /// </summary>
        public string Title { get; set; }
    }
}