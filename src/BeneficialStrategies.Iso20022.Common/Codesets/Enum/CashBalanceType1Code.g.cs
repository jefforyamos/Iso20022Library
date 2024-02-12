﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashBalanceType1Code.  ISO2002 ID# _a3xY09p-Ed-ak6NoX_4Aeg_628428306.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cash balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3xY09p-Ed-ak6NoX_4Aeg_628428306")]
[Description(@"Specifies the type of cash balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum CashBalanceType1Code
{
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "AVLB".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_a3xY1Np-Ed-ak6NoX_4Aeg_628428337")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the "escrow balance" or "sequestered balance".
    /// Encoded/decoded by serializers as "REST".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_a3xY1dp-Ed-ak6NoX_4Aeg_628428338")]
    [Description(@"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance"".")]
    Restricted = BalanceTypeCode.Restricted, // same ordinal as derivation source for type conversions
    
}
