﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMServiceType10Code.  ISO2002 ID# _urguca5EEeWCgYcWSNgX5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of service selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_urguca5EEeWCgYcWSNgX5g")]
[Description(@"Describes the type of service selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType10Code
{
    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as "CustomerTransfer".
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_u4LRca5EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer,
    
    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as "InterCustomerTransfer".
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_u4LRc65EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer,
    
    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as "Payment".
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_u4LRda5EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment,
    
    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as "AccountStatements".
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_0YbN8a5EEeWCgYcWSNgX5g")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements,
    
    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as "BalanceInquiry".
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_0ifI465EEeWCgYcWSNgX5g")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry,
    
    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as "CardVerification".
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_0rR4g65EEeWCgYcWSNgX5g")]
    [Description(@"Verification of the card.")]
    CardVerification,
    
    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as "ChosenWithdrawal".
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_002rQ65EEeWCgYcWSNgX5g")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal,
    
    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as "CustomerProfile".
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_180Y465EEeWCgYcWSNgX5g")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile,
    
    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as "DynamicCurrencyConversion".
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_3hpos65EEeWCgYcWSNgX5g")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion,
    
    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as "ExchangeRateDeposit".
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_3plcs65EEeWCgYcWSNgX5g")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit,
    
    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as "ExchangeRateWithdrawal".
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_3wSho65EEeWCgYcWSNgX5g")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal,
    
    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as "MakingChange".
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_4GOVY65EEeWCgYcWSNgX5g")]
    [Description(@"Making change between media types.")]
    MakingChange,
    
    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as "NonVerifiedDeposit".
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_4NO8U65EEeWCgYcWSNgX5g")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit,
    
    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as "PINChange".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_5ak5M65EEeWCgYcWSNgX5g")]
    [Description(@"Modification of the card PIN value.")]
    PINChange,
    
    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as "PINRecovery".
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_5g1SM65EEeWCgYcWSNgX5g")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery,
    
    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as "PINUnblock".
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_5peQ065EEeWCgYcWSNgX5g")]
    [Description(@"Unblock the PIN.")]
    PINUnblock,
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as "PreAuthorisedWithdrawal".
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_54Etg65EEeWCgYcWSNgX5g")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.")]
    PreAuthorisedWithdrawal,
    
    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as "ProfileWithdrawal".
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_68Cr865EEeWCgYcWSNgX5g")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal,
    
    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as "SelectEMVApplication".
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_7Etfw65EEeWCgYcWSNgX5g")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication,
    
    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as "StandardWithdrawal".
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_7WS_A65EEeWCgYcWSNgX5g")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal,
    
    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as "SupervisedWithdrawal".
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_7b0YM65EEeWCgYcWSNgX5g")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal,
    
    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as "VerifiedDeposit".
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_7hoFQ65EEeWCgYcWSNgX5g")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMServiceType10CodeMetadataExtensions
{
    private static readonly ATMServiceType10CodeDropdownSource _dropdownSource = new ATMServiceType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMServiceType10CodeDropdownRow GetMetadata(this ATMServiceType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


