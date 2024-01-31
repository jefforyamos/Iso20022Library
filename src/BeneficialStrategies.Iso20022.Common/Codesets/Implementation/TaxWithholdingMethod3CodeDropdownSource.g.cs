﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxWithholdingMethod3Code.  ISO2002 ID# _nyrU8L-IEeWfsa741pI6WA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxWithholdingMethod3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nyrU8L-IEeWfsa741pI6WA")]
public partial class TaxWithholdingMethod3CodeDropdownSource : EnumMetadataManager<TaxWithholdingMethod3Code,ITaxWithholdingMethod3CodeDropdownRow,TaxWithholdingMethod3CodeDropdownRow>
{
    public TaxWithholdingMethod3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxWithholdingMethod3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
