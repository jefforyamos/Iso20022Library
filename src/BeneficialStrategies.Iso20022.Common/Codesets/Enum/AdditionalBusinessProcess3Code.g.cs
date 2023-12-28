﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcess3Code.  ISO2002 ID# _bqbk09p-Ed-ak6NoX_4Aeg_1334000182.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqbk09p-Ed-ak6NoX_4Aeg_1334000182")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClaimOrCompensation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bqbk1Np-Ed-ak6NoX_4Aeg_1334000184")]
    [Description(@"??")]
    ClaimOrCompensation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bqbk1dp-Ed-ak6NoX_4Aeg_1334000217")]
    [Description(@"??")]
    TaxRefund,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalBusinessProcess3CodeMetadataExtensions
{
    private static readonly AdditionalBusinessProcess3CodeDropdownSource _dropdownSource = new AdditionalBusinessProcess3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalBusinessProcess3CodeDropdownRow GetMetadata(this AdditionalBusinessProcess3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


