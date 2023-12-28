﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FeeCollectionInitiatorCode.  ISO2002 ID# _9YEBsCxJEeyg-aG5nXcnfg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the initiator of the fee collection message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9YEBsCxJEeyg-aG5nXcnfg")]
[Description(@"Specifies the initiator of the fee collection message.")]
public enum FeeCollectionInitiatorCode
{
    /// <summary>
    /// Entity acquiring card transaction.
    /// Encoded/decoded by serializers as "ACQR".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_JLz8kCxKEeyg-aG5nXcnfg")]
    [Description(@"Entity acquiring card transaction.")]
    Acquirer,
    
    /// <summary>
    /// Entity issuing card.
    /// Encoded/decoded by serializers as "CISS".
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_k1rbkCxKEeyg-aG5nXcnfg")]
    [Description(@"Entity issuing card.")]
    CardIssuer,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer
    /// Encoded/decoded by serializers as "AGNT".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t-qZUCxKEeyg-aG5nXcnfg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer")]
    Agent,
    
    /// <summary>
    /// Other entity initiates fee collection defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-S6D4CxKEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Other entity initiates fee collection defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_HfS68CxLEeyg-aG5nXcnfg")]
    [Description(@"Other entity initiates fee collection defined at national level.")]
    OtherNational,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FeeCollectionInitiatorCodeMetadataExtensions
{
    private static readonly FeeCollectionInitiatorCodeDropdownSource _dropdownSource = new FeeCollectionInitiatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFeeCollectionInitiatorCodeDropdownRow GetMetadata(this FeeCollectionInitiatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

