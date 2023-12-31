﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAccountType3Code.  ISO2002 ID# _a3Bx99p-Ed-ak6NoX_4Aeg_-801481171.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3Bx99p-Ed-ak6NoX_4Aeg_-801481171")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType3Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as "CashPayment".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a3Bx-Np-Ed-ak6NoX_4Aeg_-729445965")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment,
    
    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as "Charges".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a3K74Np-Ed-ak6NoX_4Aeg_-728524735")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges,
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3K74dp-Ed-ak6NoX_4Aeg_-728524020")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement,
    
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3K74tp-Ed-ak6NoX_4Aeg_-728523977")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current,
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3K749p-Ed-ak6NoX_4Aeg_-728523942")]
    [Description(@"Account used for savings.")]
    Savings,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAccountType3CodeMetadataExtensions
{
    private static readonly CashAccountType3CodeDropdownSource _dropdownSource = new CashAccountType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAccountType3CodeDropdownRow GetMetadata(this CashAccountType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


