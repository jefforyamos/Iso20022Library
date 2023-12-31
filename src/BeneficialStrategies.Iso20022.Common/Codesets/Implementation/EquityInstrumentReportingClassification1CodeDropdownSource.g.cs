﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EquityInstrumentReportingClassification1Code.  ISO2002 ID# _hrceQAjsEeW36pGcc5RpFw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the equity financial instruments.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEquityInstrumentReportingClassification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hrceQAjsEeW36pGcc5RpFw")]
public partial class EquityInstrumentReportingClassification1CodeDropdownSource : EnumMetadataManager<EquityInstrumentReportingClassification1Code,IEquityInstrumentReportingClassification1CodeDropdownRow,EquityInstrumentReportingClassification1CodeDropdownRow>
{
    public EquityInstrumentReportingClassification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EquityInstrumentReportingClassification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
