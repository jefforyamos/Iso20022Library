﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResidentialStatus1Code.  ISO2002 ID# _ZUrOZtp-Ed-ak6NoX_4Aeg_-1428222113.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the residential status of an individual.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUrOZtp-Ed-ak6NoX_4Aeg_-1428222113")]
[Description(@"Specifies the residential status of an individual.")]
[DerivedFrom(typeof(ResidentialStatusCode))]
public enum ResidentialStatus1Code
{
    /// <summary>
    /// Resident.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZUrOZ9p-Ed-ak6NoX_4Aeg_-1024642437")]
    [Description(@"Resident.")]
    Resident = ResidentialStatusCode.Resident, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Permanent resident.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_ZUrOaNp-Ed-ak6NoX_4Aeg_-1024642164")]
    [Description(@"Permanent resident.")]
    PermanentResident = ResidentialStatusCode.PermanentResident, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non-resident.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_ZU0_YNp-Ed-ak6NoX_4Aeg_-1024642147")]
    [Description(@"Non-resident.")]
    NonResident = ResidentialStatusCode.NonResident, // same ordinal as derivation source for type conversions
    
}
