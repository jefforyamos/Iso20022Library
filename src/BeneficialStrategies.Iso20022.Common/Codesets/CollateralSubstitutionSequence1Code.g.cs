﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralSubstitutionSequence1Code.  ISO2002 ID# _Yb5zVtp-Ed-ak6NoX_4Aeg_811875689.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the collateral substitution request is new or updated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yb5zVtp-Ed-ak6NoX_4Aeg_811875689")]
[Description(@"Indicates whether the collateral substitution request is new or updated.")]
[DerivedFrom(typeof(CollateralSubstitutionSequenceCode))]
public enum CollateralSubstitutionSequence1Code
{
    /// <summary>
    /// Indicates this is a new collateral substitution request.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_Yb5zV9p-Ed-ak6NoX_4Aeg_1315111868")]
    [Description(@"Indicates this is a new collateral substitution request.")]
    Initial = CollateralSubstitutionSequenceCode.Initial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates this is an updated collateral substitution request.
    /// Encoded/decoded by serializers as &quot;UPDD&quot;.
    /// </summary>
    [EnumMember(Value = "UPDD")]
    [IsoId("_YcDkUNp-Ed-ak6NoX_4Aeg_-1512706665")]
    [Description(@"Indicates this is an updated collateral substitution request.")]
    Updated = CollateralSubstitutionSequenceCode.Updated, // same ordinal as derivation source for type conversions
    
}
