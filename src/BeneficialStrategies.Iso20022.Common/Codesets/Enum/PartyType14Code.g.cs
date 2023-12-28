﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType14Code.  ISO2002 ID# _yq2IkY0YEeWRYffwL7E13A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of entity involved in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yq2IkY0YEeWRYffwL7E13A")]
[Description(@"Identification of the type of entity involved in a transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType14Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OriginatingPOI".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s0Y0YEeWRYffwL7E13A")]
    [Description(@"??")]
    OriginatingPOI,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Merchant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s040YEeWRYffwL7E13A")]
    [Description(@"??")]
    Merchant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acceptor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s1Y0YEeWRYffwL7E13A")]
    [Description(@"??")]
    Acceptor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s140YEeWRYffwL7E13A")]
    [Description(@"??")]
    IntermediaryAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s2Y0YEeWRYffwL7E13A")]
    [Description(@"??")]
    Acquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s240YEeWRYffwL7E13A")]
    [Description(@"??")]
    CardIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegateIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y13s3Y0YEeWRYffwL7E13A")]
    [Description(@"??")]
    DelegateIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardApplication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3vj_oY0YEeWRYffwL7E13A")]
    [Description(@"??")]
    CardApplication,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType14CodeMetadataExtensions
{
    private static readonly PartyType14CodeDropdownSource _dropdownSource = new PartyType14CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType14CodeDropdownRow GetMetadata(this PartyType14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


