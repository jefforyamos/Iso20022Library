﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType5Code.  ISO2002 ID# _atVqcdp-Ed-ak6NoX_4Aeg_-817683940.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atVqcdp-Ed-ak6NoX_4Aeg_-817683940")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType5Code
{
    /// <summary>
    /// That part of an investment fund order attributed to a normal staff portion.
    /// Encoded/decoded by serializers as "NSPN".
    /// </summary>
    [EnumMember(Value = "NSPN")]
    [IsoId("_atVqctp-Ed-ak6NoX_4Aeg_-683770576")]
    [Description(@"That part of an investment fund order attributed to a normal staff portion.")]
    NormalStaffPortion = FundOrderTypeCode.NormalStaffPortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That part of an investment fund order attributed to a normal client portion.
    /// Encoded/decoded by serializers as "NCPN".
    /// </summary>
    [EnumMember(Value = "NCPN")]
    [IsoId("_atVqc9p-Ed-ak6NoX_4Aeg_-629285145")]
    [Description(@"That part of an investment fund order attributed to a normal client portion.")]
    NormalClientPortion = FundOrderTypeCode.NormalClientPortion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That part of an investment fund order attributed to a staff member with a savings plan.
    /// Encoded/decoded by serializers as "SWSP".
    /// </summary>
    [EnumMember(Value = "SWSP")]
    [IsoId("_atVqdNp-Ed-ak6NoX_4Aeg_-571102419")]
    [Description(@"That part of an investment fund order attributed to a staff member with a savings plan.")]
    StaffWithSavingsPlan = FundOrderTypeCode.StaffWithSavingsPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// That part of an investment fund order attributed to a client with a savings plan.
    /// Encoded/decoded by serializers as "CWSP".
    /// </summary>
    [EnumMember(Value = "CWSP")]
    [IsoId("_atVqddp-Ed-ak6NoX_4Aeg_-329138804")]
    [Description(@"That part of an investment fund order attributed to a client with a savings plan.")]
    ClientWithSavingsPlan = FundOrderTypeCode.ClientWithSavingsPlan, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType5CodeMetadataExtensions
{
    private static readonly FundOrderType5CodeDropdownSource _dropdownSource = new FundOrderType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType5CodeDropdownRow GetMetadata(this FundOrderType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


