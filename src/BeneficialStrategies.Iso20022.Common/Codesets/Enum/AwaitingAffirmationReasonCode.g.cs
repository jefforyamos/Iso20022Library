﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AwaitingAffirmationReasonCode.  ISO2002 ID# __0Jx1dojEeC60axPepSq7g_-795321397.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting affirmation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx1dojEeC60axPepSq7g_-795321397")]
[Description(@"Specifies the reason why the instruction has an awaiting affirmation status.")]
[Derivations(typeof(AwaitingAffirmationReason1Code))]
public enum AwaitingAffirmationReasonCode
{
    /// <summary>
    /// Affirmation has not been received yet.
    /// Encoded/decoded by serializers as "WAFF".
    /// </summary>
    [EnumMember(Value = "WAFF")]
    [IsoId("__0Ti0NojEeC60axPepSq7g_-909160463")]
    [Description(@"Affirmation has not been received yet.")]
    AwaitingAffirmation,
    
}
