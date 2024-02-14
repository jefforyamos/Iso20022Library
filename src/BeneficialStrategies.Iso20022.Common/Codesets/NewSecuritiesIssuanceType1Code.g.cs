﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceType1Code.  ISO2002 ID# _w-5BQBH0EeKKuerhIbkpig.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w-5BQBH0EeKKuerhIbkpig")]
[Description(@"Specifies the type of securities proceeds; whether they are newly issued or not.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType1Code
{
    /// <summary>
    /// Securities proceeds are not new issues.
    /// Encoded/decoded by serializers as &quot;EXIS&quot;.
    /// </summary>
    [EnumMember(Value = "EXIS")]
    [IsoId("_hPR4URH1EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are not new issues.")]
    ExistingIssue = NewSecuritiesIssuanceTypeCode.ExistingIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities proceeds are newly issued.
    /// Encoded/decoded by serializers as &quot;NEIS&quot;.
    /// </summary>
    [EnumMember(Value = "NEIS")]
    [IsoId("_hXeLARH1EeKKuerhIbkpig")]
    [Description(@"Securities proceeds are newly issued.")]
    NewIssue = NewSecuritiesIssuanceTypeCode.NewIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not known whether the securities proceeds are newly issued or not.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_hlxswxH1EeKKuerhIbkpig")]
    [Description(@"Not known whether the securities proceeds are newly issued or not.")]
    Unknown = NewSecuritiesIssuanceTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}
