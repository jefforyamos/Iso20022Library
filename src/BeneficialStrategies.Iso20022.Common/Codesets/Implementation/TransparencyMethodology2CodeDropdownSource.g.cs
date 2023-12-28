﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransparencyMethodology2Code.  ISO2002 ID# _EjDNwHvuEeanCNPcMT7sSg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the methodology used for a transparency operation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransparencyMethodology2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EjDNwHvuEeanCNPcMT7sSg")]
public partial class TransparencyMethodology2CodeDropdownSource : EnumMetadataManager<TransparencyMethodology2Code,ITransparencyMethodology2CodeDropdownRow,TransparencyMethodology2CodeDropdownRow>
{
    public TransparencyMethodology2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransparencyMethodology2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
