﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InformationQualifyCode.  ISO2002 ID# _2pcDINuVEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2pcDINuVEeiB5uLfkg9ZJA")]
[Description(@"Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.")]
[Derivations(typeof(InformationQualify1Code))]
public enum InformationQualifyCode
{
    /// <summary>
    /// The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_7GdBANuVEeiB5uLfkg9ZJA")]
    [Description(@"The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.")]
    Status,
    
    /// <summary>
    /// The information is related to an error situation occurring on the message sender.
    /// Encoded/decoded by serializers as &quot;ERRO&quot;.
    /// </summary>
    [EnumMember(Value = "ERRO")]
    [IsoId("__aCWENuVEeiB5uLfkg9ZJA")]
    [Description(@"The information is related to an error situation occurring on the message sender.")]
    Error,
    
    /// <summary>
    /// Standard display interface.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_CpxogNuWEeiB5uLfkg9ZJA")]
    [Description(@"Standard display interface.")]
    Display,
    
    /// <summary>
    /// Standard sound interface.
    /// Encoded/decoded by serializers as &quot;SOND&quot;.
    /// </summary>
    [EnumMember(Value = "SOND")]
    [IsoId("_E55RANuWEeiB5uLfkg9ZJA")]
    [Description(@"Standard sound interface.")]
    Sound,
    
    /// <summary>
    /// Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_HdxjANuWEeiB5uLfkg9ZJA")]
    [Description(@"Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal.")]
    Input,
    
    /// <summary>
    /// Information displayed on the Cardholder POI interface, replicated on the Cashier interface.
    /// Encoded/decoded by serializers as &quot;POIR&quot;.
    /// </summary>
    [EnumMember(Value = "POIR")]
    [IsoId("_KgoQANuWEeiB5uLfkg9ZJA")]
    [Description(@"Information displayed on the Cardholder POI interface, replicated on the Cashier interface.")]
    POIReplication,
    
    /// <summary>
    /// Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_OHkhgNuWEeiB5uLfkg9ZJA")]
    [Description(@"Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.")]
    CustomerAssistance,
    
    /// <summary>
    /// Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_RPO2ANuWEeiB5uLfkg9ZJA")]
    [Description(@"Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal.")]
    Receipt,
    
    /// <summary>
    /// When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System.
    /// Encoded/decoded by serializers as &quot;DOCT&quot;.
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_UgRwANuWEeiB5uLfkg9ZJA")]
    [Description(@"When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System.")]
    Document,
    
    /// <summary>
    /// Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_YFFTgNuWEeiB5uLfkg9ZJA")]
    [Description(@"Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed.")]
    Voucher,
    
}
