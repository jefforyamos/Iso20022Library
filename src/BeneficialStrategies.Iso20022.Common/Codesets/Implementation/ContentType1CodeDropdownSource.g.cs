﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ContentType1Code.  ISO2002 ID# _TSz5bQEcEeCQm6a_G2yO_w_780953916.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of a Cryptographic Message Syntax (CMS) data structure.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IContentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TSz5bQEcEeCQm6a_G2yO_w_780953916")]
public partial class ContentType1CodeDropdownSource : EnumMetadataManager<ContentType1Code,IContentType1CodeDropdownRow,ContentType1CodeDropdownRow>
{
    public ContentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ContentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
