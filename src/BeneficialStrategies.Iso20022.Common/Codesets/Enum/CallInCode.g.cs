﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CallInCode.  ISO2002 ID# _bXW30tp-Ed-ak6NoX_4Aeg_-343201614.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pay-in call report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXW30tp-Ed-ak6NoX_4Aeg_-343201614")]
[Description(@"Specifies the type of pay-in call report.")]
[Derivations(typeof(CallIn1Code))]
public enum CallInCode
{
    /// <summary>
    /// Pay-in call is for account value.
    /// Encoded/decoded by serializers as "CFAV".
    /// </summary>
    [EnumMember(Value = "CFAV")]
    [IsoId("_bXW309p-Ed-ak6NoX_4Aeg_-299796204")]
    [Description(@"Pay-in call is for account value.")]
    CallForAccountValue,
    
    /// <summary>
    /// Pay-in call is for settlement.
    /// Encoded/decoded by serializers as "CFST".
    /// </summary>
    [EnumMember(Value = "CFST")]
    [IsoId("_bXW31Np-Ed-ak6NoX_4Aeg_-245307801")]
    [Description(@"Pay-in call is for settlement.")]
    CallForSettlement,
    
    /// <summary>
    /// Pay-in call is for currency close.
    /// Encoded/decoded by serializers as "CFCC".
    /// </summary>
    [EnumMember(Value = "CFCC")]
    [IsoId("_bXW31dp-Ed-ak6NoX_4Aeg_-225911984")]
    [Description(@"Pay-in call is for currency close.")]
    CallForCurrencyClose,
    
}
