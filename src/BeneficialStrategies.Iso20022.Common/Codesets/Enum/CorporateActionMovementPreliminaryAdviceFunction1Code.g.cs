﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionMovementPreliminaryAdviceFunction1Code.  ISO2002 ID# _IQ0_YDQUEe2o-K1dwNg8Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IQ0_YDQUEe2o-K1dwNg8Gg")]
[Description(@"Specifies whether the message is a final eligible balance and entitlements message or a preliminary advice of payment message.")]
[DerivedFrom(typeof(CorporateActionMovementPreliminaryAdviceFunctionCode))]
public enum CorporateActionMovementPreliminaryAdviceFunction1Code
{
    /// <summary>
    /// Message is an entitlement.
    /// Encoded/decoded by serializers as "ENTL".
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_MkWqETQUEe2o-K1dwNg8Gg")]
    [Description(@"Message is an entitlement.")]
    Entitlement = CorporateActionMovementPreliminaryAdviceFunctionCode.Entitlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message is a preadvice of movement.
    /// Encoded/decoded by serializers as "CAPA".
    /// </summary>
    [EnumMember(Value = "CAPA")]
    [IsoId("_MzstojQUEe2o-K1dwNg8Gg")]
    [Description(@"Message is a preadvice of movement.")]
    PreadviceOfMovement = CorporateActionMovementPreliminaryAdviceFunctionCode.PreadviceOfMovement, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionMovementPreliminaryAdviceFunction1CodeMetadataExtensions
{
    private static readonly CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownSource _dropdownSource = new CorporateActionMovementPreliminaryAdviceFunction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionMovementPreliminaryAdviceFunction1CodeDropdownRow GetMetadata(this CorporateActionMovementPreliminaryAdviceFunction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


