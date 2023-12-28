﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IssuanceType1Code.  ISO2002 ID# _vRbJQH4MEeG05p8M2uqofg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies undertaking issuance type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIssuanceType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vRbJQH4MEeG05p8M2uqofg")]
public partial class IssuanceType1CodeDropdownSource : EnumMetadataManager<IssuanceType1Code,IIssuanceType1CodeDropdownRow,IssuanceType1CodeDropdownRow>
{
    public IssuanceType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IssuanceType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
