﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OfferorType1Code.  ISO2002 ID# _1pa8lTL3EeKU9IrkkToqcw_1480504854.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the offeror for the event is the issuing company or a third party.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOfferorType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1pa8lTL3EeKU9IrkkToqcw_1480504854")]
public partial class OfferorType1CodeDropdownSource : EnumMetadataManager<OfferorType1Code,IOfferorType1CodeDropdownRow,OfferorType1CodeDropdownRow>
{
    public OfferorType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OfferorType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
