﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AllegementReasonCode.  ISO2002 ID# __0Jx0dojEeC60axPepSq7g_-2133812073.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an allegement status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx0dojEeC60axPepSq7g_-2133812073")]
[Description(@"Specifies the reason why the instruction has an allegement status.")]
[Derivations(typeof(AllegementReason1Code))]
public enum AllegementReasonCode
{
    /// <summary>
    /// Allegement has been received and no match could be found.
    /// Encoded/decoded by serializers as &quot;ALG1&quot;.
    /// </summary>
    [EnumMember(Value = "ALG1")]
    [IsoId("__0Jx0tojEeC60axPepSq7g_1199081548")]
    [Description(@"Allegement has been received and no match could be found.")]
    AllegementReceived,
    
}
