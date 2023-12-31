﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OfficialDocumentType1Code.  ISO2002 ID# _4YsNAHhREee6_vnrijrKgg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of official document used for identification or authentication.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOfficialDocumentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4YsNAHhREee6_vnrijrKgg")]
public partial class OfficialDocumentType1CodeDropdownSource : EnumMetadataManager<OfficialDocumentType1Code,IOfficialDocumentType1CodeDropdownRow,OfficialDocumentType1CodeDropdownRow>
{
    public OfficialDocumentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OfficialDocumentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
