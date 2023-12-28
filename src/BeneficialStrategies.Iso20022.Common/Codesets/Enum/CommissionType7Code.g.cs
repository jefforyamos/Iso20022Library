﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionType7Code.  ISO2002 ID# _a_9rh9p-Ed-ak6NoX_4Aeg_1912267455.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_9rh9p-Ed-ak6NoX_4Aeg_1912267455")]
[Description(@"Specifies the type of investment fund commission.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FrontEndLoad".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a_9riNp-Ed-ak6NoX_4Aeg_1912267481")]
    [Description(@"??")]
    FrontEndLoad,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BackEndLoad".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bAHcgNp-Ed-ak6NoX_4Aeg_1912267490")]
    [Description(@"??")]
    BackEndLoad,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionType7CodeMetadataExtensions
{
    private static readonly CommissionType7CodeDropdownSource _dropdownSource = new CommissionType7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionType7CodeDropdownRow GetMetadata(this CommissionType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

