﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ERISAEligibility1Code.  ISO2002 ID# _ahtpRdp-Ed-ak6NoX_4Aeg_1496558248.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahtpRdp-Ed-ak6NoX_4Aeg_1496558248")]
[Description(@"Specifies information about ERISA (Eligibility to federal Employee Retirement Income Security Act) eligibility.")]
[DerivedFrom(typeof(ERISAEligibilityCode))]
public enum ERISAEligibility1Code
{
    /// <summary>
    /// Investor is subject to an ERISA declaration.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ahtpRtp-Ed-ak6NoX_4Aeg_-1951543252")]
    [Description(@"Investor is subject to an ERISA declaration.")]
    ERISAEligible = ERISAEligibilityCode.ERISAEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment is not subject to an ERISA declaration.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_ahtpR9p-Ed-ak6NoX_4Aeg_-1951543222")]
    [Description(@"Investment is not subject to an ERISA declaration.")]
    NotERISAEligible = ERISAEligibilityCode.NotERISAEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Eligibility is unknown at the time the order is sent, and the instructing party will confirm later.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ahtpSNp-Ed-ak6NoX_4Aeg_-1951543191")]
    [Description(@"Eligibility is unknown at the time the order is sent, and the instructing party will confirm later.")]
    ERISAEligibilityUnknown = ERISAEligibilityCode.ERISAEligibilityUnknown, // same ordinal as derivation source for type conversions
    
}
