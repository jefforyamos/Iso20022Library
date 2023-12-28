﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Eligible1Code.  ISO2002 ID# _unGN4CC9EeWPMvNwVtiMsA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is eligible or not eligible.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEligible1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_unGN4CC9EeWPMvNwVtiMsA")]
public partial class Eligible1CodeDropdownSource : EnumMetadataManager<Eligible1Code,IEligible1CodeDropdownRow,Eligible1CodeDropdownRow>
{
    public Eligible1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Eligible1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}