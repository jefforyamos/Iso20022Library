﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FileActionResultCode.  ISO2002 ID# _K1GHcFEBEee94_dUz-hvgw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// File action processing result.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFileActionResultCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K1GHcFEBEee94_dUz-hvgw")]
public partial class FileActionResultCodeDropdownSource : EnumMetadataManager<FileActionResultCode,IFileActionResultCodeDropdownRow,FileActionResultCodeDropdownRow>
{
    public FileActionResultCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FileActionResultCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
