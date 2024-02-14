﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementDate4Code.  ISO2002 ID# _ZLby1dp-Ed-ak6NoX_4Aeg_1690826366.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZLby1dp-Ed-ak6NoX_4Aeg_1690826366")]
[Description(@"Specifies the date of settlement, in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate4Code
{
    /// <summary>
    /// Settlement is to be done when the security is issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZLby1tp-Ed-ak6NoX_4Aeg_1853523100")]
    [Description(@"Settlement is to be done when the security is issued.")]
    WhenIssued = SettlementDateCode.WhenIssued, // same ordinal as derivation source for type conversions
    
}
