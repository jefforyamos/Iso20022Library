﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstalmentAmountDetailsType1Code.  ISO2002 ID# _KjGSMDEqEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KjGSMDEqEemzCpWiCwK4aQ")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[DerivedFrom(typeof(InstalmentAmountDetailsTypeCode))]
public enum InstalmentAmountDetailsType1Code
{
    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as "TAXX".
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_N8-YETEqEemzCpWiCwK4aQ")]
    [Description(@"Instalment amount tax")]
    Tax = InstalmentAmountDetailsTypeCode.Tax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as "RQST".
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_ORPX4TEqEemzCpWiCwK4aQ")]
    [Description(@"Requested amount")]
    Requested = InstalmentAmountDetailsTypeCode.Requested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Olz5sTEqEemzCpWiCwK4aQ")]
    [Description(@"Grace period unit type")]
    OtherPrivate = InstalmentAmountDetailsTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_O6hlcTEqEemzCpWiCwK4aQ")]
    [Description(@"Grace period unit type")]
    OtherNational = InstalmentAmountDetailsTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as "OTHC".
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_PO8WQTEqEemzCpWiCwK4aQ")]
    [Description(@"Other amounts")]
    OtherCharges = InstalmentAmountDetailsTypeCode.OtherCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_PjXHETEqEemzCpWiCwK4aQ")]
    [Description(@"Insurance amount")]
    Insurance = InstalmentAmountDetailsTypeCode.Insurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as "FUNA".
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_P4N8wTEqEemzCpWiCwK4aQ")]
    [Description(@"Funded amount")]
    Funded = InstalmentAmountDetailsTypeCode.Funded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as "FEES".
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_QNYUcTEqEemzCpWiCwK4aQ")]
    [Description(@"Fees amount")]
    Fees = InstalmentAmountDetailsTypeCode.Fees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as "EXPN".
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_QiZiMTEqEemzCpWiCwK4aQ")]
    [Description(@"Expense Amount")]
    Expense = InstalmentAmountDetailsTypeCode.Expense, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as "AFCO".
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_DL1y4ekYEemeDPHh-U9b6w")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost = InstalmentAmountDetailsTypeCode.AnnualFinancingCost, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstalmentAmountDetailsType1CodeMetadataExtensions
{
    private static readonly InstalmentAmountDetailsType1CodeDropdownSource _dropdownSource = new InstalmentAmountDetailsType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstalmentAmountDetailsType1CodeDropdownRow GetMetadata(this InstalmentAmountDetailsType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


