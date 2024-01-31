﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CSCManagementCode.  ISO2002 ID# _TWii4QEcEeCQm6a_G2yO_w_1480882734.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICSCManagementCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWii4QEcEeCQm6a_G2yO_w_1480882734")]
public partial class CSCManagementCodeDropdownSource : EnumMetadataManager<CSCManagementCode,ICSCManagementCodeDropdownRow,CSCManagementCodeDropdownRow>
{
    public CSCManagementCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CSCManagementCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
