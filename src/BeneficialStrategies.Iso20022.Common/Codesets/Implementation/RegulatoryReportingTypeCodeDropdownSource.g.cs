﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RegulatoryReportingTypeCode.  ISO2002 ID# _ZbPJYtp-Ed-ak6NoX_4Aeg_44026870.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRegulatoryReportingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbPJYtp-Ed-ak6NoX_4Aeg_44026870")]
public partial class RegulatoryReportingTypeCodeDropdownSource : EnumMetadataManager<RegulatoryReportingTypeCode,IRegulatoryReportingTypeCodeDropdownRow,RegulatoryReportingTypeCodeDropdownRow>
{
    public RegulatoryReportingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RegulatoryReportingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
