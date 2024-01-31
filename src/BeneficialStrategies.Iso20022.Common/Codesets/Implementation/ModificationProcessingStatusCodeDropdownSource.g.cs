﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModificationProcessingStatusCode.  ISO2002 ID# _jQp0g-5NEeCisYr99QEiWA_266324205.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModificationProcessingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jQp0g-5NEeCisYr99QEiWA_266324205")]
public partial class ModificationProcessingStatusCodeDropdownSource : EnumMetadataManager<ModificationProcessingStatusCode,IModificationProcessingStatusCodeDropdownRow,ModificationProcessingStatusCodeDropdownRow>
{
    public ModificationProcessingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModificationProcessingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
