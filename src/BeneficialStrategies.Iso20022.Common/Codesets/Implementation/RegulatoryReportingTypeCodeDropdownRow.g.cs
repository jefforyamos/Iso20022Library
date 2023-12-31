﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RegulatoryReportingTypeCode.  ISO2002 ID# _ZbPJYtp-Ed-ak6NoX_4Aeg_44026870.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RegulatoryReportingTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IRegulatoryReportingTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbPJYtp-Ed-ak6NoX_4Aeg_44026870")]
public partial class RegulatoryReportingTypeCodeDropdownRow : EnumMetadataItem<RegulatoryReportingTypeCode>, IRegulatoryReportingTypeCodeDropdownRow
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RegulatoryReportingTypeCodeDropdownRow(RegulatoryReportingTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
