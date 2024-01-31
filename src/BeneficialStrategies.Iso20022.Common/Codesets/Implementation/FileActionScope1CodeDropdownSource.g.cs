﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FileActionScope1Code.  ISO2002 ID# _O_lBYDEmEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the action applies to a file or a record.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFileActionScope1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_O_lBYDEmEemzCpWiCwK4aQ")]
public partial class FileActionScope1CodeDropdownSource : EnumMetadataManager<FileActionScope1Code,IFileActionScope1CodeDropdownRow,FileActionScope1CodeDropdownRow>
{
    public FileActionScope1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FileActionScope1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
