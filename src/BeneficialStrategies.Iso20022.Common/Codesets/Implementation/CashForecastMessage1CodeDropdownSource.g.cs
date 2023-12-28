﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashForecastMessage1Code.  ISO2002 ID# _a65lUNp-Ed-ak6NoX_4Aeg_986167915.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the fund cash forecast message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashForecastMessage1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a65lUNp-Ed-ak6NoX_4Aeg_986167915")]
public partial class CashForecastMessage1CodeDropdownSource : EnumMetadataManager<CashForecastMessage1Code,ICashForecastMessage1CodeDropdownRow,CashForecastMessage1CodeDropdownRow>
{
    public CashForecastMessage1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashForecastMessage1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}