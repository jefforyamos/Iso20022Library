﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcknowledgementReason8Code.  ISO2002 ID# _-BCUoCz2EeOsiuMH68so7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-BCUoCz2EeOsiuMH68so7Q")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason8Code
{
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__j-uESz2EeOsiuMH68so7Q")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = AcknowledgementReasonCode.NarrativeReason, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AcknowledgementReason8CodeMetadataExtensions
{
    private static readonly AcknowledgementReason8CodeDropdownSource _dropdownSource = new AcknowledgementReason8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAcknowledgementReason8CodeDropdownRow GetMetadata(this AcknowledgementReason8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


