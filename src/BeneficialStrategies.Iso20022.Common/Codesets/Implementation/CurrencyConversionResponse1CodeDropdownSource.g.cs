﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CurrencyConversionResponse1Code.  ISO2002 ID# _fRlkkEesEeODR7vDcYOqmg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of a requested currency conversion.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICurrencyConversionResponse1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fRlkkEesEeODR7vDcYOqmg")]
public partial class CurrencyConversionResponse1CodeDropdownSource : EnumMetadataManager<CurrencyConversionResponse1Code,ICurrencyConversionResponse1CodeDropdownRow,CurrencyConversionResponse1CodeDropdownRow>
{
    public CurrencyConversionResponse1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CurrencyConversionResponse1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}