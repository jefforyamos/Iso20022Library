﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FinancialInstrumentRemoval1Code.  ISO2002 ID# _MUJ0kPkNEeicy5Zn42b9bg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the removal process.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFinancialInstrumentRemoval1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MUJ0kPkNEeicy5Zn42b9bg")]
public partial class FinancialInstrumentRemoval1CodeDropdownSource : EnumMetadataManager<FinancialInstrumentRemoval1Code,IFinancialInstrumentRemoval1CodeDropdownRow,FinancialInstrumentRemoval1CodeDropdownRow>
{
    public FinancialInstrumentRemoval1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FinancialInstrumentRemoval1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}