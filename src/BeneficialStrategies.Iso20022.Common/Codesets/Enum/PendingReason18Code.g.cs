﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason18Code.  ISO2002 ID# _U_0-vOXzEemEj48jhmlA0Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U_0-vOXzEemEj48jhmlA0Q")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason18Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_U_0-v-XzEemEj48jhmlA0Q")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_U_0-xOXzEemEj48jhmlA0Q")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as "PendingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_U_0-weXzEemEj48jhmlA0Q")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as "MissingCertification".
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_U_0-xeXzEemEj48jhmlA0Q")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification,
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_U_0-veXzEemEj48jhmlA0Q")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_U_0-xuXzEemEj48jhmlA0Q")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_U_0-x-XzEemEj48jhmlA0Q")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_U_0-vuXzEemEj48jhmlA0Q")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement,
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as "PendingReceipt".
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_U_0-wOXzEemEj48jhmlA0Q")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase or loan.")]
    PendingReceipt,
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_U_0-w-XzEemEj48jhmlA0Q")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers,
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as "DisagreementOnCashAmount".
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_U_0-wuXzEemEj48jhmlA0Q")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount,
    
    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as "IncorrectTaxRate".
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_aCN6geXzEemEj48jhmlA0Q")]
    [Description(@"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.")]
    IncorrectTaxRate,
    
    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as "InconsistentTaxRate".
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_bEa-YeXzEemEj48jhmlA0Q")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate,
    
    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as "MissingTaxRate".
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_bxNL4eXzEemEj48jhmlA0Q")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason18CodeMetadataExtensions
{
    private static readonly PendingReason18CodeDropdownSource _dropdownSource = new PendingReason18CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason18CodeDropdownRow GetMetadata(this PendingReason18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


