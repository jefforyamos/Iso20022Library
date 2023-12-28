﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEquityInstrumentReportingClassification1Code.  ISO2002 ID# _YAQMcPPREeS_qLctCs2aRQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the non-equity financial instruments.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEquityInstrumentReportingClassification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YAQMcPPREeS_qLctCs2aRQ")]
public partial class NonEquityInstrumentReportingClassification1CodeDropdownSource : EnumMetadataManager<NonEquityInstrumentReportingClassification1Code,INonEquityInstrumentReportingClassification1CodeDropdownRow,NonEquityInstrumentReportingClassification1CodeDropdownRow>
{
    public NonEquityInstrumentReportingClassification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEquityInstrumentReportingClassification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}