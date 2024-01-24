﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BidTypeCode.  ISO2002 ID# _begosNp-Ed-ak6NoX_4Aeg_451517447.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code to identify the type of bid request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_begosNp-Ed-ak6NoX_4Aeg_451517447")]
[Description(@"Code to identify the type of bid request.")]
[Derivations(typeof(BidType1Code))]
public enum BidTypeCode
{
    /// <summary>
    /// Bid type is non disclosed.
    /// Encoded/decoded by serializers as "NDIS".
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_begosdp-Ed-ak6NoX_4Aeg_467216118")]
    [Description(@"Bid type is non disclosed.")]
    NonDisclosed,
    
    /// <summary>
    /// Bid type is disclosed.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_begostp-Ed-ak6NoX_4Aeg_481992122")]
    [Description(@"Bid type is disclosed.")]
    Disclosed,
    
    /// <summary>
    /// List order is not related to a bid.
    /// Encoded/decoded by serializers as "NOBI".
    /// </summary>
    [EnumMember(Value = "NOBI")]
    [IsoId("_begos9p-Ed-ak6NoX_4Aeg_487533177")]
    [Description(@"List order is not related to a bid.")]
    NoBid,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BidTypeCodeMetadataExtensions
{
    private static readonly BidTypeCodeDropdownSource _dropdownSource = new BidTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBidTypeCodeDropdownRow GetMetadata(this BidTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


