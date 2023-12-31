﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResidenceType1Code.  ISO2002 ID# _JX1ngGjNEeiRg5NzP0jkQg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResidenceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JX1ngGjNEeiRg5NzP0jkQg")]
public partial class ResidenceType1CodeDropdownSource : EnumMetadataManager<ResidenceType1Code,IResidenceType1CodeDropdownRow,ResidenceType1CodeDropdownRow>
{
    public ResidenceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResidenceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
