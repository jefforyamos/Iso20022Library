﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnitOfMeasure1Code.  ISO2002 ID# _TUTHIwEcEeCQm6a_G2yO_w_859190881.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of measure of the item purchased.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnitOfMeasure1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUTHIwEcEeCQm6a_G2yO_w_859190881")]
public partial class UnitOfMeasure1CodeDropdownSource : EnumMetadataManager<UnitOfMeasure1Code,IUnitOfMeasure1CodeDropdownRow,UnitOfMeasure1CodeDropdownRow>
{
    public UnitOfMeasure1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnitOfMeasure1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
