/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Ref Data Primary Key entity.
    /// </summary>
    public partial class RefDataPrimaryKey : IPrimaryKey
    {
        /// <summary>
        /// Gets the corresponding <c>Key1</c> text (read-only where selected).
        /// </summary>
        public string? Key1Text { get; set; }

        /// <summary>
        /// Gets or sets the Key1 code.
        /// </summary>
        public string? Key1 { get; set; }

        /// <summary>
        /// Gets or sets the Other.
        /// </summary>
        public string? Other { get; set; }
        
        /// <summary>
        /// Creates the primary <see cref="CompositeKey"/>.
        /// </summary>
        /// <returns>The primary <see cref="CompositeKey"/>.</returns>
        /// <param name="key1">The <see cref="Key1"/>.</param>
        public static CompositeKey CreatePrimaryKey(string? key1) => CompositeKey.Create(key1);

        /// <summary>
        /// Gets the primary <see cref="CompositeKey"/> (consists of the following property(s): <see cref="Key1"/>).
        /// </summary>
        [JsonIgnore]
        public CompositeKey PrimaryKey => CreatePrimaryKey(Key1);
    }
}

#pragma warning restore
#nullable restore