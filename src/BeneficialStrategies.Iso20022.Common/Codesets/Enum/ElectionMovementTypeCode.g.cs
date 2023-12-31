﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ElectionMovementTypeCode.  ISO2002 ID# _ag-CY9p-Ed-ak6NoX_4Aeg_855319504.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the effect on the holdings of electing a Corporate Action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag-CY9p-Ed-ak6NoX_4Aeg_855319504")]
[Description(@"Specifies the effect on the holdings of electing a Corporate Action option.")]
[Derivations(typeof(ElectionMovementType2Code),typeof(ElectionMovementType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ElectionMovementTypeCode
{
    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as "REST".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ag-CZNp-Ed-ak6NoX_4Aeg_872869307")]
    [Description(@"Election results in a change of balance type that transfers control of the securities rather than the securities themselves.")]
    Restricted,
    
    /// <summary>
    /// Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.
    /// Encoded/decoded by serializers as "DRCT".
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_ag-CZdp-Ed-ak6NoX_4Aeg_872869308")]
    [Description(@"Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.")]
    Direct,
    
    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as "SEQD".
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_ag-CZtp-Ed-ak6NoX_4Aeg_-1056877029")]
    [Description(@"Election results in a change of balance type that transfers control of the securities rather than the securities themselves.")]
    Sequestered,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ElectionMovementTypeCodeMetadataExtensions
{
    private static readonly ElectionMovementTypeCodeDropdownSource _dropdownSource = new ElectionMovementTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IElectionMovementTypeCodeDropdownRow GetMetadata(this ElectionMovementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


