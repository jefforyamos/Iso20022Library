﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency19Code.  ISO2002 ID# _ln76kSLBEe2KAJot-YBP6w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the frequency of an interest payment with a time unit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency19CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ln76kSLBEe2KAJot-YBP6w")]
public partial class Frequency19CodeDropdownSource : EnumMetadataManager<Frequency19Code,IFrequency19CodeDropdownRow,Frequency19CodeDropdownRow>
{
    public Frequency19CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency19CodeDropdownRow(enumValue, memberInfo))
    {
    }
}