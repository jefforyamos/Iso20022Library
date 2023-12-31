﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcceptedStatusReasonCode.  ISO2002 ID# _-51rIGBlEeaR1OOiVxm3Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for an accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-51rIGBlEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for an accepted status.")]
[Derivations(typeof(AcceptedStatusReason1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AcceptedStatusReasonCode
{
    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code.
    /// Encoded/decoded by serializers as "SECT".
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_2GWm0GBmEeaR1OOiVxm3Gg")]
    [Description(@"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code.")]
    SectorNotAllowed,
    
    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place.
    /// Encoded/decoded by serializers as "PLAC".
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_DsPNsGBnEeaR1OOiVxm3Gg")]
    [Description(@"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place.")]
    PlaceNotAllowed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AcceptedStatusReasonCodeMetadataExtensions
{
    private static readonly AcceptedStatusReasonCodeDropdownSource _dropdownSource = new AcceptedStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAcceptedStatusReasonCodeDropdownRow GetMetadata(this AcceptedStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


