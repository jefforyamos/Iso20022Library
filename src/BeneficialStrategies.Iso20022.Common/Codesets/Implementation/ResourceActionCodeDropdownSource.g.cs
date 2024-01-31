﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResourceActionCode.  ISO2002 ID# _LI9QYC7_Eeu125Ip9zFcsQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on a media resource.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResourceActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LI9QYC7_Eeu125Ip9zFcsQ")]
public partial class ResourceActionCodeDropdownSource : EnumMetadataManager<ResourceActionCode,IResourceActionCodeDropdownRow,ResourceActionCodeDropdownRow>
{
    public ResourceActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResourceActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
