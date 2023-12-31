﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SupportDocumentType1Code.  ISO2002 ID# _MSMgcNnTEeS--7IJLPC9lw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of supporting document.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISupportDocumentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MSMgcNnTEeS--7IJLPC9lw")]
public partial class SupportDocumentType1CodeDropdownSource : EnumMetadataManager<SupportDocumentType1Code,ISupportDocumentType1CodeDropdownRow,SupportDocumentType1CodeDropdownRow>
{
    public SupportDocumentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SupportDocumentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
