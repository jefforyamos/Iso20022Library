﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProtectTransactionType3Code.  ISO2002 ID# _Hq0xkLpaEeilsanBGAzy4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of protect instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Hq0xkLpaEeilsanBGAzy4A")]
[Description(@"Specifies the type of protect instruction.")]
[DerivedFrom(typeof(ReorganisationTransactionTypeCode))]
public enum ProtectTransactionType3Code
{
    /// <summary>
    /// Reorganisation is a protect transaction type.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_Kp2HcbpaEeilsanBGAzy4A")]
    [Description(@"Reorganisation is a protect transaction type.")]
    ProtectTransaction = ReorganisationTransactionTypeCode.ProtectTransaction, // same ordinal as derivation source for type conversions
    
}
