﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SpecialPurposeCode.  ISO2002 ID# _WjGtkBvUEeWeg9zOuV6DZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies special purpose codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WjGtkBvUEeWeg9zOuV6DZQ")]
[Description(@"Specifies special purpose codes.")]
public enum SpecialPurposeCode
{
    /// <summary>
    /// Blank value.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_aerLQBvUEeWeg9zOuV6DZQ")]
    [Description(@"Blank value.")]
    BLNK,
    
    /// <summary>
    /// Not available (N/A).
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_brFsUBvaEeWeg9zOuV6DZQ")]
    [Description(@"Not available (N/A).")]
    NTAV,
    
    /// <summary>
    /// Any MIC code.
    /// </summary>
    [EnumMember(Value = "ANYM")]
    [IsoId("_KyeQMB3ZEeWNp95x0ENf8w")]
    [Description(@"Any MIC code.")]
    ANYM,
    
    /// <summary>
    /// Value not reported by the party.
    /// </summary>
    [EnumMember(Value = "NORP")]
    [IsoId("_3wXcQNGeEeaQk737TH1Fzw")]
    [Description(@"Value not reported by the party.")]
    NORP,
    
    /// <summary>
    /// No reason to report or no reason available to report.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_rM9R8OtfEeqXXbgP9HbjvA")]
    [Description(@"No reason to report or no reason available to report.")]
    NORE,
    
    /// <summary>
    /// Not applicable (N/A).
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_M1W0YICCEeqdQubSe21TTw")]
    [Description(@"Not applicable (N/A).")]
    NOAP,
    
    /// <summary>
    /// Positive indication.
    /// </summary>
    [EnumMember(Value = "TRUE")]
    [IsoId("_KQB1wOG8EeyjU5A7t8P1KA")]
    [Description(@"Positive indication.")]
    TRUE,
    
    /// <summary>
    /// Negative indication.
    /// </summary>
    [EnumMember(Value = "FALS")]
    [IsoId("_NSF4kOG8EeyjU5A7t8P1KA")]
    [Description(@"Negative indication.")]
    FALS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SpecialPurposeCodeMetadataExtensions
{
    private static readonly SpecialPurposeCodeDropdownSource _dropdownSource = new SpecialPurposeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISpecialPurposeCodeDropdownRow GetMetadata(this SpecialPurposeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


