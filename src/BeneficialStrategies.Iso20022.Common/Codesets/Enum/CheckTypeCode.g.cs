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
[Derivations(typeof(CheckType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CheckTypeCode
{
    /// <summary>
    /// The check belongs to an individual.
    /// Encoded/decoded by serializers as "PERS".
    /// </summary>
    [EnumMember(Value = "PERS")]
    [IsoId("_OZCGwNtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to an individual.")]
    PersonalCheck,
    
    /// <summary>
    /// The check belongs to a Company or a professional entity.
    /// Encoded/decoded by serializers as "BUSI".
    /// </summary>
    [EnumMember(Value = "BUSI")]
    [IsoId("_RSSy4NtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to a Company or a professional entity.")]
    BusinessCheck,
    
    /// <summary>
    /// The check is guaranteed by a bank.
    /// Encoded/decoded by serializers as "BANK".
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_UmnDUNtbEeipuvJHTHIw9A")]
    [Description(@"The check is guaranteed by a bank.")]
    BankCheck,
    
    /// <summary>
    /// Check issued by a company for the employees.
    /// Encoded/decoded by serializers as "PAYR".
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_YQXYQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by a company for the employees.")]
    PayrollCheck,
    
    /// <summary>
    /// Check issued by Government.
    /// Encoded/decoded by serializers as "GOVC".
    /// </summary>
    [EnumMember(Value = "GOVC")]
    [IsoId("_bkxIQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by Government.")]
    GovernmentCheck,
    
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


