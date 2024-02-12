﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountPermissionTypeCode.  ISO2002 ID# _fJFegJiuEeO4o528ngEXuw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies different levels of permission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fJFegJiuEeO4o528ngEXuw")]
[Description(@"Specifies different levels of permission.")]
[Derivations(typeof(AccountPermissionType1Code))]
public enum AccountPermissionTypeCode
{
    /// <summary>
    /// No right to use the account.
    /// Encoded/decoded by serializers as "NORI".
    /// </summary>
    [EnumMember(Value = "NORI")]
    [IsoId("_lCwnoJiuEeO4o528ngEXuw")]
    [Description(@"No right to use the account.")]
    NoRight,
    
    /// <summary>
    /// Right to use the account alone.
    /// Encoded/decoded by serializers as "RIAL".
    /// </summary>
    [EnumMember(Value = "RIAL")]
    [IsoId("_smNK8JiuEeO4o528ngEXuw")]
    [Description(@"Right to use the account alone.")]
    RightToUseAlone,
    
    /// <summary>
    /// Right to use the account together with another person.
    /// Encoded/decoded by serializers as "RIWI".
    /// </summary>
    [EnumMember(Value = "RIWI")]
    [IsoId("_0GHSEJiuEeO4o528ngEXuw")]
    [Description(@"Right to use the account together with another person.")]
    RightToUseWithOther,
    
}
