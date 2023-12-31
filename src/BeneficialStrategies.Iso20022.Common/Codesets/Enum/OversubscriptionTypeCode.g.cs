﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OversubscriptionTypeCode.  ISO2002 ID# _1pktlTL3EeKU9IrkkToqcw_-2000683477.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the oversubscription type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pktlTL3EeKU9IrkkToqcw_-2000683477")]
[Description(@"Specifies the oversubscription type.")]
[Derivations(typeof(OversubscriptionType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum OversubscriptionTypeCode
{
    /// <summary>
    /// Unlimited oversubscription.
    /// Encoded/decoded by serializers as "UNLD".
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_1puekDL3EeKU9IrkkToqcw_2035989338")]
    [Description(@"Unlimited oversubscription.")]
    Unlimited,
    
    /// <summary>
    /// The subscription is limited by quantity or percentage.
    /// Encoded/decoded by serializers as "LTDB".
    /// </summary>
    [EnumMember(Value = "LTDB")]
    [IsoId("_1puekTL3EeKU9IrkkToqcw_684397253")]
    [Description(@"The subscription is limited by quantity or percentage.")]
    LimitedByQuantityOrPercentage,
    
    /// <summary>
    /// No oversubscription is allowed.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_1puekjL3EeKU9IrkkToqcw_613549737")]
    [Description(@"No oversubscription is allowed.")]
    NoOversubscription,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OversubscriptionTypeCodeMetadataExtensions
{
    private static readonly OversubscriptionTypeCodeDropdownSource _dropdownSource = new OversubscriptionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOversubscriptionTypeCodeDropdownRow GetMetadata(this OversubscriptionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


