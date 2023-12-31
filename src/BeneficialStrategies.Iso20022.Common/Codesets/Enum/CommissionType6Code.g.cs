﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionType6Code.  ISO2002 ID# _a_9rg9p-Ed-ak6NoX_4Aeg_2025119069.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_9rg9p-Ed-ak6NoX_4Aeg_2025119069")]
[Description(@"Specifies the type of investment fund commission.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType6Code
{
    /// <summary>
    /// Commission for subscribing to an investment, paid at the time of the subscription.
    /// Encoded/decoded by serializers as "FrontEndLoad".
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a_9rhNp-Ed-ak6NoX_4Aeg_2072219495")]
    [Description(@"Commission for subscribing to an investment, paid at the time of the subscription.")]
    FrontEndLoad,
    
    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as "BackEndLoad".
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a_9rhdp-Ed-ak6NoX_4Aeg_2072219512")]
    [Description(@"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.")]
    BackEndLoad,
    
    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as "CommissionDePlacement".
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_a_9rhtp-Ed-ak6NoX_4Aeg_22575918")]
    [Description(@"Amount of cash due to an intermediary for selling a product, or services, to a third party.")]
    CommissionDePlacement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionType6CodeMetadataExtensions
{
    private static readonly CommissionType6CodeDropdownSource _dropdownSource = new CommissionType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionType6CodeDropdownRow GetMetadata(this CommissionType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


