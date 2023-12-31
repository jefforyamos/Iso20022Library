﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LegalStructureFinancialInstrumentCode.  ISO2002 ID# _-MDTkDQeEeifw8iDiyZLmQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILegalStructureFinancialInstrumentCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MDTkDQeEeifw8iDiyZLmQ")]
public partial class LegalStructureFinancialInstrumentCodeDropdownSource : EnumMetadataManager<LegalStructureFinancialInstrumentCode,ILegalStructureFinancialInstrumentCodeDropdownRow,LegalStructureFinancialInstrumentCodeDropdownRow>
{
    public LegalStructureFinancialInstrumentCodeDropdownSource()
        : base( (enumValue, memberInfo) => new LegalStructureFinancialInstrumentCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
