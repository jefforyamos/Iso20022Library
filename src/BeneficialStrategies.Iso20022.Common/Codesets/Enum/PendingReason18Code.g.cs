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
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-v-XzEemEj48jhmlA0Q")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-xOXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-weXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    PendingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingCertification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-xeXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    MissingCertification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientMoney".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-veXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    InsufficientMoney,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-xuXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    LackOfSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-x-XzEemEj48jhmlA0Q")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityDisagreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-vuXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    QuantityDisagreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingReceipt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-wOXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    PendingReceipt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongCertificatesNumbers".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-w-XzEemEj48jhmlA0Q")]
    [Description(@"??")]
    WrongCertificatesNumbers,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisagreementOnCashAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U_0-wuXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    DisagreementOnCashAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncorrectTaxRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aCN6geXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    IncorrectTaxRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InconsistentTaxRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bEa-YeXzEemEj48jhmlA0Q")]
    [Description(@"??")]
    InconsistentTaxRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingTaxRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bxNL4eXzEemEj48jhmlA0Q")]
    [Description(@"??")]
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


