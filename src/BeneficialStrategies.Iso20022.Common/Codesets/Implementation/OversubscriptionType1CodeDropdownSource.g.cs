﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OversubscriptionType1Code.  ISO2002 ID# _1rW2QTL3EeKU9IrkkToqcw_-402247570.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the oversubscription type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOversubscriptionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1rW2QTL3EeKU9IrkkToqcw_-402247570")]
public partial class OversubscriptionType1CodeDropdownSource : EnumMetadataManager<OversubscriptionType1Code,IOversubscriptionType1CodeDropdownRow,OversubscriptionType1CodeDropdownRow>
{
    public OversubscriptionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OversubscriptionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
