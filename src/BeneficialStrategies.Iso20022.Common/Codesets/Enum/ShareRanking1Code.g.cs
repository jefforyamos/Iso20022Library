﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ShareRanking1Code.  ISO2002 ID# _ZOkmZdp-Ed-ak6NoX_4Aeg_1470328796.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the shares are ranking for dividend or pari passu.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOkmZdp-Ed-ak6NoX_4Aeg_1470328796")]
[Description(@"Specifies whether the shares are ranking for dividend or pari passu.")]
[DerivedFrom(typeof(ShareRankingCode))]
public enum ShareRanking1Code
{
    /// <summary>
    /// Payable on the date specified.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_ZOkmZtp-Ed-ak6NoX_4Aeg_1470328798")]
    [Description(@"Payable on the date specified.")]
    Dividend = ShareRankingCode.Dividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pari Passu. With equal rights as other shares of the company.
    /// Encoded/decoded by serializers as "PARI".
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_ZOkmZ9p-Ed-ak6NoX_4Aeg_1470328827")]
    [Description(@"Pari Passu. With equal rights as other shares of the company.")]
    PariPassu = ShareRankingCode.PariPassu, // same ordinal as derivation source for type conversions
    
}
