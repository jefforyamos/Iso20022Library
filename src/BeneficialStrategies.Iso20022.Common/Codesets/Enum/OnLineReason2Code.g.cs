﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OnLineReason2Code.  ISO2002 ID# _3n55AU4LEey_VecAUE-C9Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to process an online authorisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3n55AU4LEey_VecAUE-C9Q")]
[Description(@"Reason to process an online authorisation.")]
[DerivedFrom(typeof(OnLineReasonCode))]
public enum OnLineReason2Code
{
    /// <summary>
    /// Transaction random selection to go online.
    /// Encoded/decoded by serializers as "RandomSelection".
    /// </summary>
    [EnumMember(Value = "RNDM")]
    [IsoId("_3vH7UU4LEey_VecAUE-C9Q")]
    [Description(@"Transaction random selection to go online.")]
    RandomSelection,
    
    /// <summary>
    /// Payment application in the Integrated Circuit Card forces to go on-line.
    /// Encoded/decoded by serializers as "ICCForced".
    /// </summary>
    [EnumMember(Value = "ICCF")]
    [IsoId("_3vH7U04LEey_VecAUE-C9Q")]
    [Description(@"Payment application in the Integrated Circuit Card forces to go on-line.")]
    ICCForced,
    
    /// <summary>
    /// On line forced by card acceptor.
    /// Encoded/decoded by serializers as "MerchantForced".
    /// </summary>
    [EnumMember(Value = "MERF")]
    [IsoId("_3vH7VU4LEey_VecAUE-C9Q")]
    [Description(@"On line forced by card acceptor.")]
    MerchantForced,
    
    /// <summary>
    /// Terminal random selection to go online.
    /// Encoded/decoded by serializers as "TerminalForced".
    /// </summary>
    [EnumMember(Value = "TRMF")]
    [IsoId("_3vH7V04LEey_VecAUE-C9Q")]
    [Description(@"Terminal random selection to go online.")]
    TerminalForced,
    
    /// <summary>
    /// On line forced by card issuer.
    /// Encoded/decoded by serializers as "IssuerForced".
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_3vH7WU4LEey_VecAUE-C9Q")]
    [Description(@"On line forced by card issuer.")]
    IssuerForced,
    
    /// <summary>
    /// Over floor limit.
    /// Encoded/decoded by serializers as "FloorLimit".
    /// </summary>
    [EnumMember(Value = "FRLT")]
    [IsoId("_3vH7W04LEey_VecAUE-C9Q")]
    [Description(@"Over floor limit.")]
    FloorLimit,
    
    /// <summary>
    /// Card appears on terminal exception file.
    /// Encoded/decoded by serializers as "ExceptionFile".
    /// </summary>
    [EnumMember(Value = "EXFL")]
    [IsoId("_3vH7XU4LEey_VecAUE-C9Q")]
    [Description(@"Card appears on terminal exception file.")]
    ExceptionFile,
    
    /// <summary>
    /// Total amount of purchases per cardholder and per application above floor limit.
    /// Encoded/decoded by serializers as "TotalAmount".
    /// </summary>
    [EnumMember(Value = "TAMT")]
    [IsoId("_3vH7X04LEey_VecAUE-C9Q")]
    [Description(@"Total amount of purchases per cardholder and per application above floor limit.")]
    TotalAmount,
    
    /// <summary>
    /// Bank Identification Number under control.
    /// Encoded/decoded by serializers as "ControlledBIN".
    /// </summary>
    [EnumMember(Value = "CBIN")]
    [IsoId("_3vH7YU4LEey_VecAUE-C9Q")]
    [Description(@"Bank Identification Number under control.")]
    ControlledBIN,
    
    /// <summary>
    /// Unknown Bank Identification Number.
    /// Encoded/decoded by serializers as "UnknownBIN".
    /// </summary>
    [EnumMember(Value = "UBIN")]
    [IsoId("_3vH7Y04LEey_VecAUE-C9Q")]
    [Description(@"Unknown Bank Identification Number.")]
    UnknownBIN,
    
    /// <summary>
    /// Primary account number (card number) under control.
    /// Encoded/decoded by serializers as "ControlledPAN".
    /// </summary>
    [EnumMember(Value = "CPAN")]
    [IsoId("_3vH7ZU4LEey_VecAUE-C9Q")]
    [Description(@"Primary account number (card number) under control.")]
    ControlledPAN,
    
    /// <summary>
    /// Flow control.
    /// Encoded/decoded by serializers as "FlowControl".
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_3vH7Z04LEey_VecAUE-C9Q")]
    [Description(@"Flow control.")]
    FlowControl,
    
    /// <summary>
    /// Unknown currency code or foreign currency.
    /// Encoded/decoded by serializers as "UnavailableCurrency".
    /// </summary>
    [EnumMember(Value = "CRCY")]
    [IsoId("_3vH7aU4LEey_VecAUE-C9Q")]
    [Description(@"Unknown currency code or foreign currency.")]
    UnavailableCurrency,
    
    /// <summary>
    /// Request Cardholder Authentication througth PIN insertion
    /// Encoded/decoded by serializers as "IssuerForcedPINRequest".
    /// </summary>
    [EnumMember(Value = "IFPR")]
    [IsoId("_9wKQsE4LEey_VecAUE-C9Q")]
    [Description(@"Request Cardholder Authentication througth PIN insertion")]
    IssuerForcedPINRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OnLineReason2CodeMetadataExtensions
{
    private static readonly OnLineReason2CodeDropdownSource _dropdownSource = new OnLineReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOnLineReason2CodeDropdownRow GetMetadata(this OnLineReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


