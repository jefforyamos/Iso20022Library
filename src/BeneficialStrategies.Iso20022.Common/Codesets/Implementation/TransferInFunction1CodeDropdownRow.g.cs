﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransferInFunction1Code.  ISO2002 ID# _iCdscCVOEeWI0orciOKunQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the transfer in.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransferInFunction1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransferInFunction1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iCdscCVOEeWI0orciOKunQ")]
public partial class TransferInFunction1CodeDropdownRow : EnumMetadataItem<TransferInFunction1Code>, ITransferInFunction1CodeDropdownRow
{
    /// <summary>
    /// Specifies the function of the transfer in.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransferInFunction1CodeDropdownRow(TransferInFunction1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
