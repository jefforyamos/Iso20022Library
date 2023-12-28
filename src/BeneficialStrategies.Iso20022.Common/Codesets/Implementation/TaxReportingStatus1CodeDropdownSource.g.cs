﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxReportingStatus1Code.  ISO2002 ID# _rHMhkWueEeaRcazd7EYKFQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of tax reporting transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxReportingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rHMhkWueEeaRcazd7EYKFQ")]
public partial class TaxReportingStatus1CodeDropdownSource : EnumMetadataManager<TaxReportingStatus1Code,ITaxReportingStatus1CodeDropdownRow,TaxReportingStatus1CodeDropdownRow>
{
    public TaxReportingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxReportingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}