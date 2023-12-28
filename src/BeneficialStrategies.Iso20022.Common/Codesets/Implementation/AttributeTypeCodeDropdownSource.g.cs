﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AttributeTypeCode.  ISO2002 ID# _TVyU5gEcEeCQm6a_G2yO_w_-64929302.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of attribute of a distinguished name (DN).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAttributeTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVyU5gEcEeCQm6a_G2yO_w_-64929302")]
public partial class AttributeTypeCodeDropdownSource : EnumMetadataManager<AttributeTypeCode,IAttributeTypeCodeDropdownRow,AttributeTypeCodeDropdownRow>
{
    public AttributeTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AttributeTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}