﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RegulatoryReportingType1Code.  ISO2002 ID# _ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "Credit".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_ZbFYZ9p-Ed-ak6NoX_4Aeg_-1519759906")]
    [Description(@"Regulatory information applies to the credit side.")]
    Credit,
    
    /// <summary>
    /// Regulatory information applies to the debit side.
    /// Encoded/decoded by serializers as "Debit".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_ZbPJYNp-Ed-ak6NoX_4Aeg_-1464346584")]
    [Description(@"Regulatory information applies to the debit side.")]
    Debit,
    
    /// <summary>
    /// Regulatory information applies to both credit and debit sides.
    /// Encoded/decoded by serializers as "Both".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_ZbPJYdp-Ed-ak6NoX_4Aeg_-1237159367")]
    [Description(@"Regulatory information applies to both credit and debit sides.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RegulatoryReportingType1CodeMetadataExtensions
{
    private static readonly RegulatoryReportingType1CodeDropdownSource _dropdownSource = new RegulatoryReportingType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRegulatoryReportingType1CodeDropdownRow GetMetadata(this RegulatoryReportingType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


