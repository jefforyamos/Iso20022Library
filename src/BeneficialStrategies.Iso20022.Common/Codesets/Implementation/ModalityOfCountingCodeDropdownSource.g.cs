﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModalityOfCountingCode.  ISO2002 ID# _OLoUAK-uEemJ1NnLPsTFaw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Modality through which the votes that have been recorded and counted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModalityOfCountingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OLoUAK-uEemJ1NnLPsTFaw")]
public partial class ModalityOfCountingCodeDropdownSource : EnumMetadataManager<ModalityOfCountingCode,IModalityOfCountingCodeDropdownRow,ModalityOfCountingCodeDropdownRow>
{
    public ModalityOfCountingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModalityOfCountingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
