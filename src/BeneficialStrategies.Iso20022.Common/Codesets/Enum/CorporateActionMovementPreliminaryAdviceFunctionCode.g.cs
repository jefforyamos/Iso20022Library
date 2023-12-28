﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionMovementPreliminaryAdviceFunctionCode.  ISO2002 ID# _EHaIYDQTEe2o-K1dwNg8Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EHaIYDQTEe2o-K1dwNg8Gg")]
[Description(@"Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.")]
[Derivations(typeof(CorporateActionMovementPreliminaryAdviceFunction1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionMovementPreliminaryAdviceFunctionCode
{
    /// <summary>
    /// Message is an entitlement.
    /// Encoded/decoded by serializers as "ENTL".
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_u2ONQDQTEe2o-K1dwNg8Gg")]
    [Description(@"Message is an entitlement.")]
    Entitlement,
    
    /// <summary>
    /// Message is a preadvice of movement.
    /// Encoded/decoded by serializers as "CAPA".
    /// </summary>
    [EnumMember(Value = "CAPA")]
    [IsoId("_2oqO0DQTEe2o-K1dwNg8Gg")]
    [Description(@"Message is a preadvice of movement.")]
    PreadviceOfMovement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionMovementPreliminaryAdviceFunctionCodeMetadataExtensions
{
    private static readonly CorporateActionMovementPreliminaryAdviceFunctionCodeDropdownSource _dropdownSource = new CorporateActionMovementPreliminaryAdviceFunctionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionMovementPreliminaryAdviceFunctionCodeDropdownRow GetMetadata(this CorporateActionMovementPreliminaryAdviceFunctionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


