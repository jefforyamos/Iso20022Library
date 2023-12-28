﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InformationQualify1Code.  ISO2002 ID# _FbE-INwoEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FbE-INwoEeioifFt1dhnJA")]
[Description(@"Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.")]
[DerivedFrom(typeof(InformationQualifyCode))]
public enum InformationQualify1Code
{
    /// <summary>
    /// Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.
    /// Encoded/decoded by serializers as "CustomerAssistance".
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_GjG9MdwoEeioifFt1dhnJA")]
    [Description(@"Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.")]
    CustomerAssistance,
    
    /// <summary>
    /// Standard display interface.
    /// Encoded/decoded by serializers as "Display".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_GnixQdwoEeioifFt1dhnJA")]
    [Description(@"Standard display interface.")]
    Display,
    
    /// <summary>
    /// When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System.
    /// Encoded/decoded by serializers as "Document".
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_Gr_zcdwoEeioifFt1dhnJA")]
    [Description(@"When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System.")]
    Document,
    
    /// <summary>
    /// The information is related to an error situation occurring on the message sender.
    /// Encoded/decoded by serializers as "Error".
    /// </summary>
    [EnumMember(Value = "ERRO")]
    [IsoId("_Gwn0wdwoEeioifFt1dhnJA")]
    [Description(@"The information is related to an error situation occurring on the message sender.")]
    Error,
    
    /// <summary>
    /// Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal.
    /// Encoded/decoded by serializers as "Input".
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_G05QwdwoEeioifFt1dhnJA")]
    [Description(@"Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal.")]
    Input,
    
    /// <summary>
    /// Information displayed on the Cardholder POI interface, replicated on the Cashier interface.
    /// Encoded/decoded by serializers as "POIReplication".
    /// </summary>
    [EnumMember(Value = "POIR")]
    [IsoId("_G5TPodwoEeioifFt1dhnJA")]
    [Description(@"Information displayed on the Cardholder POI interface, replicated on the Cashier interface.")]
    POIReplication,
    
    /// <summary>
    /// Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal.
    /// Encoded/decoded by serializers as "Receipt".
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_G-USgdwoEeioifFt1dhnJA")]
    [Description(@"Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal.")]
    Receipt,
    
    /// <summary>
    /// Standard sound interface.
    /// Encoded/decoded by serializers as "Sound".
    /// </summary>
    [EnumMember(Value = "SOND")]
    [IsoId("_HC7swdwoEeioifFt1dhnJA")]
    [Description(@"Standard sound interface.")]
    Sound,
    
    /// <summary>
    /// The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.
    /// Encoded/decoded by serializers as "Status".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_HGsLYdwoEeioifFt1dhnJA")]
    [Description(@"The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.")]
    Status,
    
    /// <summary>
    /// Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed.
    /// Encoded/decoded by serializers as "Voucher".
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_HMHd8dwoEeioifFt1dhnJA")]
    [Description(@"Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed.")]
    Voucher,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InformationQualify1CodeMetadataExtensions
{
    private static readonly InformationQualify1CodeDropdownSource _dropdownSource = new InformationQualify1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInformationQualify1CodeDropdownRow GetMetadata(this InformationQualify1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


