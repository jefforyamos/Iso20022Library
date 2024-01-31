﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AwaitingAffirmationReason1Code.  ISO2002 ID# __0Jx09ojEeC60axPepSq7g_-961152106.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting affirmation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx09ojEeC60axPepSq7g_-961152106")]
[Description(@"Specifies the reason why the instruction has an awaiting affirmation status.")]
[DerivedFrom(typeof(AwaitingAffirmationReasonCode))]
public enum AwaitingAffirmationReason1Code
{
    /// <summary>
    /// Affirmation has not been received yet.
    /// Encoded/decoded by serializers as "WAFF".
    /// </summary>
    [EnumMember(Value = "WAFF")]
    [IsoId("__0Jx1NojEeC60axPepSq7g_684115329")]
    [Description(@"Affirmation has not been received yet.")]
    AwaitingAffirmation = AwaitingAffirmationReasonCode.AwaitingAffirmation, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AwaitingAffirmationReason1CodeMetadataExtensions
{
    private static readonly AwaitingAffirmationReason1CodeDropdownSource _dropdownSource = new AwaitingAffirmationReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAwaitingAffirmationReason1CodeDropdownRow GetMetadata(this AwaitingAffirmationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


