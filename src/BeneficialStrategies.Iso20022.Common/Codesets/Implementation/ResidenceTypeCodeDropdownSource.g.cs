﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResidenceTypeCode.  ISO2002 ID# _-WZTUGjMEeiRg5NzP0jkQg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResidenceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-WZTUGjMEeiRg5NzP0jkQg")]
public partial class ResidenceTypeCodeDropdownSource : EnumMetadataManager<ResidenceTypeCode,IResidenceTypeCodeDropdownRow,ResidenceTypeCodeDropdownRow>
{
    public ResidenceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResidenceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
