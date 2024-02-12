﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ServiceTaxDesignation1Code.  ISO2002 ID# _6WNcspqlEeGSON8vddiWzQ_908042461.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the taxable status of the service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WNcspqlEeGSON8vddiWzQ_908042461")]
[Description(@"Defines the taxable status of the service.")]
[DerivedFrom(typeof(ServiceTaxDesignationCode))]
public enum ServiceTaxDesignation1Code
{
    /// <summary>
    /// No taxes are due.
    /// Encoded/decoded by serializers as "XMPT".
    /// </summary>
    [EnumMember(Value = "XMPT")]
    [IsoId("_6WNcs5qlEeGSON8vddiWzQ_476426734")]
    [Description(@"No taxes are due.")]
    Exempt = ServiceTaxDesignationCode.Exempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is due but at zero percent and a zero charge.
    /// Encoded/decoded by serializers as "ZERO".
    /// </summary>
    [EnumMember(Value = "ZERO")]
    [IsoId("_6WNctJqlEeGSON8vddiWzQ_-303620587")]
    [Description(@"Tax is due but at zero percent and a zero charge.")]
    ZeroRate = ServiceTaxDesignationCode.ZeroRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One or more taxes are due on this service.
    /// Encoded/decoded by serializers as "TAXE".
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_6WNctZqlEeGSON8vddiWzQ_-314719364")]
    [Description(@"One or more taxes are due on this service.")]
    Taxable = ServiceTaxDesignationCode.Taxable, // same ordinal as derivation source for type conversions
    
}
