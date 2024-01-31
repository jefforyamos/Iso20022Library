﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModalityOfCounting1Code.  ISO2002 ID# _QzPaAK-vEemJ1NnLPsTFaw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the modality through which the votes that have been recorded and counted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModalityOfCounting1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QzPaAK-vEemJ1NnLPsTFaw")]
public partial class ModalityOfCounting1CodeDropdownSource : EnumMetadataManager<ModalityOfCounting1Code,IModalityOfCounting1CodeDropdownRow,ModalityOfCounting1CodeDropdownRow>
{
    public ModalityOfCounting1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModalityOfCounting1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
