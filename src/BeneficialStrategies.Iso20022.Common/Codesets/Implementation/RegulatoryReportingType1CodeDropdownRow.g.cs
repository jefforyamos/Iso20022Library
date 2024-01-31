﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RegulatoryReportingType1Code.  ISO2002 ID# _ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RegulatoryReportingType1CodeDropdownSource"/>.
/// Implements <seealso cref="IRegulatoryReportingType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174")]
public partial class RegulatoryReportingType1CodeDropdownRow : EnumMetadataItem<RegulatoryReportingType1Code>, IRegulatoryReportingType1CodeDropdownRow
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RegulatoryReportingType1CodeDropdownRow(RegulatoryReportingType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
