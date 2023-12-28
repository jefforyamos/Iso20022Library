﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InitialPhysicalFormCode.  ISO2002 ID# _hblKmGliEeGaMcKyqKNRfQ_420935209.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the physical form of the securities.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInitialPhysicalFormCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hblKmGliEeGaMcKyqKNRfQ_420935209")]
public partial class InitialPhysicalFormCodeDropdownSource : EnumMetadataManager<InitialPhysicalFormCode,IInitialPhysicalFormCodeDropdownRow,InitialPhysicalFormCodeDropdownRow>
{
    public InitialPhysicalFormCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InitialPhysicalFormCodeDropdownRow(enumValue, memberInfo))
    {
    }
}