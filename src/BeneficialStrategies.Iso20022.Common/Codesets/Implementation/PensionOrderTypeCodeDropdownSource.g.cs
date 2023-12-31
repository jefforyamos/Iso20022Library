﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PensionOrderTypeCode.  ISO2002 ID# _QyyooLTpEeiENt6AoDfPXg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of order attached to a pension.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPensionOrderTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QyyooLTpEeiENt6AoDfPXg")]
public partial class PensionOrderTypeCodeDropdownSource : EnumMetadataManager<PensionOrderTypeCode,IPensionOrderTypeCodeDropdownRow,PensionOrderTypeCodeDropdownRow>
{
    public PensionOrderTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PensionOrderTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
