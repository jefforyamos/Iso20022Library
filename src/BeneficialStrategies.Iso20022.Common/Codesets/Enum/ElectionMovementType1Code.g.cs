﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ElectionMovementType1Code.  ISO2002 ID# _ag04dtp-Ed-ak6NoX_4Aeg_1964804965.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the effect on the holdings of electing a Corporate Action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag04dtp-Ed-ak6NoX_4Aeg_1964804965")]
[Description(@"Specifies the effect on the holdings of electing a Corporate Action option.")]
[DerivedFrom(typeof(ElectionMovementTypeCode))]
public enum ElectionMovementType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Restricted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ag04d9p-Ed-ak6NoX_4Aeg_1964804967")]
    [Description(@"??")]
    Restricted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Direct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ag04eNp-Ed-ak6NoX_4Aeg_1964804975")]
    [Description(@"??")]
    Direct,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ElectionMovementType1CodeMetadataExtensions
{
    private static readonly ElectionMovementType1CodeDropdownSource _dropdownSource = new ElectionMovementType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IElectionMovementType1CodeDropdownRow GetMetadata(this ElectionMovementType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


