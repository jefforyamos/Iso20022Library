﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RegulatoryReportingType1Code.  ISO2002 ID# _ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174")]
[Description(@"Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.")]
[DerivedFrom(typeof(RegulatoryReportingTypeCode))]
public enum RegulatoryReportingType1Code
{
    /// <summary>
    /// Regulatory information applies to the credit side.
    /// Encoded/decoded by serializers as "CRED".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_ZbFYZ9p-Ed-ak6NoX_4Aeg_-1519759906")]
    [Description(@"Regulatory information applies to the credit side.")]
    Credit = RegulatoryReportingTypeCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory information applies to the debit side.
    /// Encoded/decoded by serializers as "DEBT".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_ZbPJYNp-Ed-ak6NoX_4Aeg_-1464346584")]
    [Description(@"Regulatory information applies to the debit side.")]
    Debit = RegulatoryReportingTypeCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory information applies to both credit and debit sides.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_ZbPJYdp-Ed-ak6NoX_4Aeg_-1237159367")]
    [Description(@"Regulatory information applies to both credit and debit sides.")]
    Both = RegulatoryReportingTypeCode.Both, // same ordinal as derivation source for type conversions
    
}
