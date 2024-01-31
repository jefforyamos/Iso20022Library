﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminalTypeCode.  ISO2002 ID# _71JA8ECGEeeXpbqDpLawug.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of terminal under the control of the card acceptor used for the card transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminalTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_71JA8ECGEeeXpbqDpLawug")]
public partial class TerminalTypeCodeDropdownSource : EnumMetadataManager<TerminalTypeCode,ITerminalTypeCodeDropdownRow,TerminalTypeCodeDropdownRow>
{
    public TerminalTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminalTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
