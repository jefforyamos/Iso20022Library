﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QualifiedDividendTaxCode.  ISO2002 ID# _1mSwEDL3EeKU9IrkkToqcw_1943389310.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the dividend as a whole or in part qualifies for lower/favourable tax rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQualifiedDividendTaxCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1mSwEDL3EeKU9IrkkToqcw_1943389310")]
public partial class QualifiedDividendTaxCodeDropdownSource : EnumMetadataManager<QualifiedDividendTaxCode,IQualifiedDividendTaxCodeDropdownRow,QualifiedDividendTaxCodeDropdownRow>
{
    public QualifiedDividendTaxCodeDropdownSource()
        : base( (enumValue, memberInfo) => new QualifiedDividendTaxCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
