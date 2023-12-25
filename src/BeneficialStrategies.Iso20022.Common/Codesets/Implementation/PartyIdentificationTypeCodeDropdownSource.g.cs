﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyIdentificationTypeCode.  ISO2002 ID# _yG5lsEU8EeSGWeX3z5zSZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyIdentificationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yG5lsEU8EeSGWeX3z5zSZQ")]
public partial class PartyIdentificationTypeCodeDropdownSource : EnumMetadataManager<PartyIdentificationTypeCode,IPartyIdentificationTypeCodeDropdownRow,PartyIdentificationTypeCodeDropdownRow>
{
    public PartyIdentificationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyIdentificationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
