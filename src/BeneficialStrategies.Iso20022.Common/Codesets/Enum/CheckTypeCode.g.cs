﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CheckTypeCode.  ISO2002 ID# _I5k0cNtbEeipuvJHTHIw9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of bank check.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I5k0cNtbEeipuvJHTHIw9A")]
[Description(@"Type of bank check.")]
public enum CheckTypeCode
{
    /// <summary>
    /// The check belongs to an individual.
    /// </summary>
    [EnumMember(Value = "PERS")]
    [IsoId("_OZCGwNtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to an individual.")]
    PERS,
    
    /// <summary>
    /// The check belongs to a Company or a professional entity.
    /// </summary>
    [EnumMember(Value = "BUSI")]
    [IsoId("_RSSy4NtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to a Company or a professional entity.")]
    BUSI,
    
    /// <summary>
    /// The check is guaranteed by a bank.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_UmnDUNtbEeipuvJHTHIw9A")]
    [Description(@"The check is guaranteed by a bank.")]
    BANK,
    
    /// <summary>
    /// Check issued by a company for the employees.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_YQXYQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by a company for the employees.")]
    PAYR,
    
    /// <summary>
    /// Check issued by Government.
    /// </summary>
    [EnumMember(Value = "GOVC")]
    [IsoId("_bkxIQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by Government.")]
    GOVC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CheckTypeCodeMetadataExtensions
{
    private static readonly CheckTypeCodeDropdownSource _dropdownSource = new CheckTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICheckTypeCodeDropdownRow GetMetadata(this CheckTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


