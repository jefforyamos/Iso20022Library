﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CreditQuality1Code.  ISO2002 ID# _cDPBAKckEeaGcf8_qtd8Yw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Assessment of the credit quality of a party or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICreditQuality1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cDPBAKckEeaGcf8_qtd8Yw")]
public partial class CreditQuality1CodeDropdownSource : EnumMetadataManager<CreditQuality1Code,ICreditQuality1CodeDropdownRow,CreditQuality1CodeDropdownRow>
{
    public CreditQuality1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CreditQuality1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
