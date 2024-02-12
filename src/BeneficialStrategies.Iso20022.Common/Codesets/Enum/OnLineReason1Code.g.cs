﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OnLineReason1Code.  ISO2002 ID# _TTZvUgEcEeCQm6a_G2yO_w_1798387883.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to process an online authorisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTZvUgEcEeCQm6a_G2yO_w_1798387883")]
[Description(@"Reason to process an online authorisation.")]
[DerivedFrom(typeof(OnLineReasonCode))]
public enum OnLineReason1Code
{
    /// <summary>
    /// Transaction random selection to go online.
    /// Encoded/decoded by serializers as "RNDM".
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_TTjgQAEcEeCQm6a_G2yO_w_2040768907")]
    [Description(@"Transaction random selection to go online.")]
    RandomSelection = OnLineReasonCode.RandomSelection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application in the Integrated Circuit Card forces to go on-line.
    /// Encoded/decoded by serializers as "ICCF".
    /// </summary>
    [EnumMember(Value = "ICCF")]
    [IsoId("_TTjgQQEcEeCQm6a_G2yO_w_-179105698")]
    [Description(@"Payment application in the Integrated Circuit Card forces to go on-line.")]
    ICCForced = OnLineReasonCode.ICCForced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On line forced by card acceptor.
    /// Encoded/decoded by serializers as "MERF".
    /// </summary>
    [EnumMember(Value = "MERF")]
    [IsoId("_TTjgQgEcEeCQm6a_G2yO_w_1651817471")]
    [Description(@"On line forced by card acceptor.")]
    MerchantForced = OnLineReasonCode.MerchantForced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal random selection to go online.
    /// Encoded/decoded by serializers as "TRMF".
    /// </summary>
    [EnumMember(Value = "TRMF")]
    [IsoId("_TTjgQwEcEeCQm6a_G2yO_w_2105904740")]
    [Description(@"Terminal random selection to go online.")]
    TerminalForced = OnLineReasonCode.TerminalForced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On line forced by card issuer.
    /// Encoded/decoded by serializers as "ISSF".
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_TTjgRAEcEeCQm6a_G2yO_w_-1428297403")]
    [Description(@"On line forced by card issuer.")]
    IssuerForced = OnLineReasonCode.IssuerForced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Over floor limit.
    /// Encoded/decoded by serializers as "FRLT".
    /// </summary>
    [EnumMember(Value = "FRLT")]
    [IsoId("_TTjgRQEcEeCQm6a_G2yO_w_-842350377")]
    [Description(@"Over floor limit.")]
    FloorLimit = OnLineReasonCode.FloorLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card appears on terminal exception file.
    /// Encoded/decoded by serializers as "EXFL".
    /// </summary>
    [EnumMember(Value = "EXFL")]
    [IsoId("_TTjgRgEcEeCQm6a_G2yO_w_307951533")]
    [Description(@"Card appears on terminal exception file.")]
    ExceptionFile = OnLineReasonCode.ExceptionFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total amount of purchases per cardholder and per application above floor limit.
    /// Encoded/decoded by serializers as "TAMT".
    /// </summary>
    [EnumMember(Value = "TAMT")]
    [IsoId("_TTjgRwEcEeCQm6a_G2yO_w_296852756")]
    [Description(@"Total amount of purchases per cardholder and per application above floor limit.")]
    TotalAmount = OnLineReasonCode.TotalAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Identification Number under control.
    /// Encoded/decoded by serializers as "CBIN".
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_TTjgSAEcEeCQm6a_G2yO_w_750940025")]
    [Description(@"Bank Identification Number under control.")]
    ControlledBIN = OnLineReasonCode.ControlledBIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown Bank Identification Number.
    /// Encoded/decoded by serializers as "UBIN".
    /// </summary>
    [EnumMember(Value = "UBIN")]
    [IsoId("_TTjgSQEcEeCQm6a_G2yO_w_1011311913")]
    [Description(@"Unknown Bank Identification Number.")]
    UnknownBIN = OnLineReasonCode.UnknownBIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Primary account number (card number) under control.
    /// Encoded/decoded by serializers as "CPAN".
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_TTjgSgEcEeCQm6a_G2yO_w_-298867480")]
    [Description(@"Primary account number (card number) under control.")]
    ControlledPAN = OnLineReasonCode.ControlledPAN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Flow control.
    /// Encoded/decoded by serializers as "FLOW".
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_TTjgSwEcEeCQm6a_G2yO_w_-933899326")]
    [Description(@"Flow control.")]
    FlowControl = OnLineReasonCode.FlowControl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown currency code or foreign currency.
    /// Encoded/decoded by serializers as "CRCY".
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("_TTjgTAEcEeCQm6a_G2yO_w_741166815")]
    [Description(@"Unknown currency code or foreign currency.")]
    UnavailableCurrency = OnLineReasonCode.UnavailableCurrency, // same ordinal as derivation source for type conversions
    
}
